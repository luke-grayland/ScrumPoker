using System.Text.Json;
using Microsoft.AspNetCore.SignalR;
using ScrumPoker.Controllers;
using ScrumPoker.Models;

namespace ScrumPoker.Hubs
{
    public class ScrumPokerHub : Hub
    {
        private readonly IGameController _gameController;
        private GameModel _game;
        
        public ScrumPokerHub(IGameController gameController)
        {
            _gameController = gameController;
            _game = GameModelSingleton.Instance.Game;
        }
        
        [HubMethodName("TestButton")]
        public async Task TestButton(string message)
        {
            await Clients.All.SendAsync("SignalRShowCardsAndAverage", message);
            //not yet implemented
        }

        [HubMethodName("UpdateLocalGameModel")]
        public async Task UpdateLocalGameModel(string jsonGameModel)
        {
            var gameModel = JsonSerializer.Deserialize<GameModel>(jsonGameModel);
            Console.WriteLine(gameModel);
        }
        
        
        [HubMethodName("ReceiveGameModelUpdate")]
        public async Task ReceiveGameModelUpdate(GameModel gameModel)
        {
            await Clients.All.SendAsync("ReceiveGameModelUpdate", gameModel);
        }
    }
}

