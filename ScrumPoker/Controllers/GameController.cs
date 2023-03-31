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

        public GameController(ICardHelper cardHelper)
        {
            _cardHelper = cardHelper;
        }

        public IActionResult InitialiseGame(
            IList<int> votingCardValues,
            string playerName)
        {
            var votingCardRows = _cardHelper.SplitCardsToRows(votingCardValues);

            var player = PlayerModelSingleton.Instance.Player;
            player.Name = playerName;
            player.Card.Name = playerName; //shouldn't be two names
            player.Card.CardValue = 0;
            player.SpectactorOnly = false;

            var gameConfig = new GameModel(
                votingCardRows.Item1,
                votingCardRows.Item2,
                player);

            return View("GameView", gameConfig);
        }

        // public IActionResult JoinGame(
        //     IList<int> votingCardValues,
        //     string playerName)
        // {
        //     var votingCardRows = _cardHelper.SplitCardsToRows(votingCardValues);

        //     var gameConfig = new GameModel(
        //         votingCardRows.Item1,
        //         votingCardRows.Item2);

        //     gameConfig.Players.Add(new PlayerModel(playerName, 0, false));

        //     return View("GameView", gameConfig);
        // }

    }
}

