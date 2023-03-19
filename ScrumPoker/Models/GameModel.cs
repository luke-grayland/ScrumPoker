using System;
namespace ScrumPoker.Models
{
    public class GameModel
    {
        public int TotalPlayers { get; set; }
        public IList<int> VotingCardValues { get; set; }

        public GameModel(IList<int> votingCardValues)
        {
            VotingCardValues = votingCardValues;
        }
    }
}

    