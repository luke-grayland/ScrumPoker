using Microsoft.AspNetCore.Mvc;

namespace ScrumPoker.Controllers;

public interface IGameController
{
    public Task<IActionResult> InitialiseGame(IList<int> votingCardValues, string playerName);
    
    public JsonResult ShowCards();
    
}