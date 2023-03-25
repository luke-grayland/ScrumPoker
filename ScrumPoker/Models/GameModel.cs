using System;
namespace ScrumPoker.Models
{
    public class GameModel
    {
        public int TotalPlayers { get; set; }
        public IList<PlayerModel> Players { get; set; }
        public IList<int> VotingCardsTopRow { get; set; }
        public IList<int> VotingCardsBottomRow { get; set; }

        public GameModel(
            IList<PlayerModel> players,
            IList<int> votingCardsTopRow,
            IList<int> votingCardsBottomRow)
        {
            Players = players;
            VotingCardsTopRow = votingCardsTopRow;
            VotingCardsBottomRow = votingCardsBottomRow;
        }
    }
}

    