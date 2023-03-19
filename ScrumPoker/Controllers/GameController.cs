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

            var votingCardRows = _cardHelper.SplitCardsToRows(votingCardValues);

            var gameConfig = new GameModel(votingCardRows.Item1, votingCardRows.Item2);

            return View("GameView", gameConfig);
        }
    }
}

