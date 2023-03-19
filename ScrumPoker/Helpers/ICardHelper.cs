using System;
namespace ScrumPoker.Helpers
{
    public interface ICardHelper
    {
        public Tuple<List<int>, List<int>> SplitCardsToRows(IList<int> votingCardsVales);
    }
}

