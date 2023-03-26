using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ScrumPoker.Helpers;
using ScrumPoker.Models;

namespace ScrumPoker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGameHelper _gameHelper;

    public HomeController(ILogger<HomeController> logger, IGameHelper gameHelper)
    {
        _logger = logger;
        _gameHelper = gameHelper;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult StartGame()
    {
        var playerName =
            _gameHelper.SanitiseValidateName(Request.Form["playerName"]);

        var votingCardValues =
            _gameHelper.FormatVotingCardValues(Request.Form["votingSystem"]);

        var gameConfig = new RouteValueDictionary()
        {
            {"votingCardValues", votingCardValues},
            {"playerName", playerName}
        };

        return RedirectToAction("InitialiseGame", "Game", gameConfig);
    }

    //public IActionResult JoinGame()
    //{
    //    return RedirectToAction("JoinGame", "Game", routeValues);
    //}

}

