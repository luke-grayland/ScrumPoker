using System;
namespace ScrumPoker.Models
{
    public class GameModel
    {
        public IList<PlayerModel> Players { get; set; } = new List<PlayerModel>();
        public string VotingSystem { get; set; } = "";
        public IList<int> VotingCardsTopRow { get; set; } = new List<int>();
        public IList<int> VotingCardsBottomRow { get; set; } = new List<int>();

        public string? Message { get; set; }

    }
}

