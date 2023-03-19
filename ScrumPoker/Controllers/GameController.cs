using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrumPoker.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScrumPoker.Controllers
{
    public class GameController : Controller
    {
        public IActionResult InitialiseGame(IList<int> votingCardValues)
        {
            var gameConfig = new GameModel(votingCardValues);

            return View("GameView", gameConfig);
        }
    }
}

