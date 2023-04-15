namespace ScrumPoker.Helpers
{
    public class CardHelper : ICardHelper
    {
        public Tuple<List<int>, List<int>> SplitCardsToRows(IList<int> votingCardsVales)
        {
            var topRow = new List<int>();
            var bottomRow = new List<int>();
            var topRowCount = (int)Math.Ceiling(votingCardsVales.Count / 2.0);

            for (var i = 0; i < topRowCount; i++)
            {
                topRow.Add(votingCardsVales[i]);
            }

            for (var i = topRowCount; i < votingCardsVales.Count; i++)
            {
                bottomRow.Add(votingCardsVales[i]);
            }

            return Tuple.Create(topRow, bottomRow);
        }
    }
}

