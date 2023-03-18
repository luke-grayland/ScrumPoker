using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrumPoker.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScrumPoker.Controllers
{
    public class CardController : Controller
    {
        // GET: /<controller>/
        public IActionResult CreateCard()
        {
            var card = new CardModel(5);

            return View(card);
        }
    }
}

