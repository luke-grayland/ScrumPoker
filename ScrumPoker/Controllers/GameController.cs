using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrumPoker.Helpers;
using ScrumPoker.Models;

namespace ScrumPoker.Controllers
{
    public class GameController : Controller
    {
        private readonly ICardHelper _cardHelper;
        private readonly IGameHelper _gameHelper;
        private PlayerModel _player;
        private GameModel _game;

        public GameController(ICardHelper cardHelper, IGameHelper gameHelper)
        {
            _cardHelper = cardHelper;
            _gameHelper = gameHelper;
            _player = PlayerModelSingleton.Instance.Player;
            _game = GameModelSingleton.Instance.Game;
        }

        public IActionResult InitialiseGame(
            IList<int> votingCardValues,
            string playerName)
        {
            var votingCardRows = _cardHelper.SplitCardsToRows(votingCardValues);

            _player.Name = playerName;
            _player.Card.MyCard = true;

            _game.Players.Add(_player);
            _game.VotingCardsTopRow = votingCardRows.Item1;
            _game.VotingCardsBottomRow = votingCardRows.Item2;

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

