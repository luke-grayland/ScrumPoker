﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ScrumPoker.Models;

namespace ScrumPoker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

    public IActionResult StartGame()
    {
        var cardValues = new List<int> { 1, 2, 3 };

        var routeValues = new RouteValueDictionary()
        {
            { "cardValues", cardValues }
        };

        return RedirectToAction("InitialiseGame", "Game", routeValues);
    }

}

