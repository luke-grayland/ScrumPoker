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

            var gameConfig = new GameModel(
                votingCardRows.Item1,
                votingCardRows.Item2);

            gameConfig.Players.Add(new PlayerModel(playerName, 1));

            return View("GameView", gameConfig);
        }

        public IActionResult JoinGame(
            IList<int> votingCardValues,
            string playerName)
        {
            var players = new List<PlayerModel>()
                {
                    new PlayerModel("Luke", 3),
                    new PlayerModel("Tom", 5),
                    new PlayerModel("Fred", 3),
                    new PlayerModel("James", 8),
                    new PlayerModel("Tina", 13),
                    new PlayerModel("Bea", 21),
                    new PlayerModel("Sarah", 11),
                    new PlayerModel("Muhammad", 3),
                    new PlayerModel("Faye", 2),
                    new PlayerModel("Perry", 11)
                };

            var votingCardRows = _cardHelper.SplitCardsToRows(votingCardValues);

            var gameConfig = new GameModel(
                votingCardRows.Item1,
                votingCardRows.Item2);

            gameConfig.Players.Add(new PlayerModel(playerName, 1));

            return View("GameView", gameConfig);
        }

    }
}

