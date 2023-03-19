using System;
namespace ScrumPoker.Models
{
    public class GameModel
    {
        public int TotalPlayers { get; set; }
        public IList<int> VotingCardsTopRow { get; set; }
        public IList<int> VotingCardsBottomRow { get; set; }

        public GameModel(
            IList<int> votingCardsTopRow,
            IList<int> votingCardsBottomRow)
        {
            VotingCardsTopRow = votingCardsTopRow;
            VotingCardsBottomRow = votingCardsBottomRow;
        }
    }
}

    