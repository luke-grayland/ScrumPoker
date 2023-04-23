using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ScrumPoker.Helpers;
using ScrumPoker.Models;
using ScrumPoker.Singletons;

namespace ScrumPoker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGameHelper _gameHelper;
    private readonly GameModel _game;

    public HomeController(ILogger<HomeController> logger, IGameHelper gameHelper)
    {
        _logger = logger;
        _gameHelper = gameHelper;
        _game = GameModelSingleton.Instance.Game;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Index()
    {
        _game.Players.Clear();
        _game.VotingCardsBottomRow.Clear();
        _game.VotingCardsTopRow.Clear();

        return View();
    }

    [HttpPost]
    public IActionResult StartGame(PlayerGameViewModel playerGameViewModel)
    {
        if (playerGameViewModel.VotingSystem == null ||
            playerGameViewModel.PlayerName == null)
            throw new NullReferenceException();

        var votingCardValues =
            _gameHelper.FormatVotingCardValues(playerGameViewModel.VotingSystem);

        var playerName =
            _gameHelper.SanitiseValidateName(playerGameViewModel.PlayerName);

        var gameConfig = new RouteValueDictionary()
        {
            {"votingCardValues", votingCardValues},
            {"playerName", playerName}
        };

        return RedirectToAction("InitialiseGame", "Game", gameConfig);
    }

    public void JoinGame()
    {
        // return RedirectToAction("JoinGame", "Game", routeValues);
    }

}

