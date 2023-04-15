using Microsoft.AspNetCore.Mvc;
using ScrumPoker.Models;

namespace ScrumPoker.Controllers
{
    public class PlayerController : Controller
    {
        private readonly PlayerModel _player;
        public PlayerController()
        {
            _player = PlayerModelSingleton.Instance.Player;
        }

        [HttpPost]
        public IActionResult UpdatePlayerVote(int cardValue)
        {
            _player.Card.CardValue = cardValue;

            return new OkResult();
        }
    }
}