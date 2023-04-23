using System.Text.Json;
using Microsoft.AspNetCore.SignalR;
using ScrumPoker.Controllers;
using ScrumPoker.Models;
using ScrumPoker.Singletons;

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

        [HubMethodName("ReceiveGameModelUpdate")]
        public async Task ReceiveGameModelUpdate(GameModel gameModel) 
        {
            await Clients.All.SendAsync("ReceiveGameModelUpdate", gameModel);
        }
        
        [HubMethodName("UpdateLocalGameModel")]
        public async Task UpdateLocalGameModel(string jsonGameModel)
        {
            var gameModel = JsonSerializer.Deserialize<GameModel>(jsonGameModel);
            _game = gameModel;
            
        }
    }
}

