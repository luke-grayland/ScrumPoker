using System.Collections.Concurrent;
using ScrumPoker.Models;

namespace ScrumPoker.Helpers
{
    public interface IGameHelper
    {
        public List<int> FormatVotingCardValues(string votingCardValues);
        public decimal CalculateAverageScore(IList<PlayerModel> players);
        public string SanitiseValidateName(string name);
    }
}

