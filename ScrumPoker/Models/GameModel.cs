using System;
using System.Collections.Concurrent;

namespace ScrumPoker.Models
{
    public class GameModel
    {
        public ConcurrentBag<PlayerModel> Players { get; set; } = new ConcurrentBag<PlayerModel>();
        public string VotingSystem { get; set; } = "";
        public IList<int> VotingCardsTopRow { get; set; } = new List<int>();
        public IList<int> VotingCardsBottomRow { get; set; } = new List<int>();

        public string? Message { get; set; }

    }
}

