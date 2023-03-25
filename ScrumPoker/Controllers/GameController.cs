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

        public GameController()
        {
            _cardHelper = new CardHelper(); // TODO find DI framework to use
        }

        public IActionResult InitialiseGame(IList<int> votingCardValues)
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
                players,
                votingCardRows.Item1,
                votingCardRows.Item2);

            return View("GameView", gameConfig);
        }
    }
}

