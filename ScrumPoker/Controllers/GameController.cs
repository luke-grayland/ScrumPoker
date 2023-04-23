using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ScrumPoker.Helpers;
using ScrumPoker.Models;
using ScrumPoker.Hubs;
using Microsoft.AspNetCore.SignalR;
using ScrumPoker.Singletons;

namespace ScrumPoker.Controllers
{
    public class GameController : Controller, IGameController
    {
        private readonly ICardHelper _cardHelper;
        private readonly IGameHelper _gameHelper;
        private readonly PlayerModel _player;
        private readonly GameModel _game;
        private readonly IHubContext<ScrumPokerHub> _scrumPokerHub;

        public GameController(
            ICardHelper cardHelper, 
            IGameHelper gameHelper,
            IHubContext<ScrumPokerHub> scrumPokerHub)
        {
            _cardHelper = cardHelper;
            _gameHelper = gameHelper;
            _player = PlayerModelSingleton.Instance.Player;
            _game = GameModelSingleton.Instance.Game;
            _scrumPokerHub = scrumPokerHub;
        }

        public async Task<IActionResult> InitialiseGame(
            IList<int> votingCardValues,
            string playerName)
        {
            var votingCardRows = _cardHelper.SplitCardsToRows(votingCardValues);

            _player.Name = playerName;
            _player.Card.MyCard = true;

            if (GameModelSingleton.Instance.Game.Players.Any(x => x.Card.MyCard))
                throw new Exception("Game owner already exists");
            
            if (GameModelSingleton.Instance.Game.Players.Any(x => x.Id == _player.Id))
                _player.Id = Guid.NewGuid();
            
            _game.Players.Add(_player);
            
            _game.VotingCardsTopRow = votingCardRows.Item1;
            _game.VotingCardsBottomRow = votingCardRows.Item2;

            var gameModelJson = JsonSerializer.Serialize(_game);
            await _scrumPokerHub.Clients.All.SendAsync("ReceiveGameModelUpdate", gameModelJson);

            return View("GameView", _game);
        }

        [HttpGet]
        public JsonResult ShowCards()
        {
            var scores = new
            {
                averageScore = _gameHelper.CalculateAverageScore(_game.Players),
                myCardValue = _player.Card.CardValue
            };

            return Json(scores);
        }

    }
}

