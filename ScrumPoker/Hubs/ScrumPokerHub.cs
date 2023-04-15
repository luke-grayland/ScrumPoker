using System;
using Microsoft.AspNetCore.SignalR;

namespace ScrumPoker.Hubs
{
    public class ScrumPokerHub : Hub
    {
        [HubMethodName("TestButton")]
        public async Task TestButton(string message)
        {
            await Clients.All.SendAsync("SignalRShowCardsAndAverage", message);
            //not yet implemented
        }

    }
}

