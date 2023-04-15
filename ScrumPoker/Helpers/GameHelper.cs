using ScrumPoker.Models;

namespace ScrumPoker.Helpers
{
    public class GameHelper : IGameHelper
    {
        public List<int> FormatVotingCardValues(string votingCardValues)
        {
            return votingCardValues.Split(',').Select(int.Parse).ToList();
        }

        public string SanitiseValidateName(string name)
        {
            return name; //write this method
        }

        public decimal CalculateAverageScore(IList<PlayerModel> players)
        {
            if (players == null)
                return 0;

            var count = 0;
            var totalScore = 0;

            foreach (var player in players)
            {
                totalScore += player.Card.CardValue;
                count++;
            }

            return Math.Round(totalScore / (decimal)count, 1);
        }
    }
}

