using System;
namespace ScrumPoker.Helpers
{
    public class GameHelper : IGameHelper
    {
        public GameHelper()
        {
        }

        public List<int> FormatVotingCardValues(string votingCardValues)
        {
            return votingCardValues.Split(',').Select(x => int.Parse(x)).ToList();
        }

        public string SanitiseValidateName(string name)
        {
            return name; //write this method
        }
    }
}

