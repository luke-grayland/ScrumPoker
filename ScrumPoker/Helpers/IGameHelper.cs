using System;
namespace ScrumPoker.Helpers
{
    public interface IGameHelper
    {
        public List<int> FormatVotingCardValues(string votingCardValues);
        public string SanitiseValidateName(string name);
    }
}

