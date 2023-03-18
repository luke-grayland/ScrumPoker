using System;
namespace ScrumPoker.Models
{
    public class GameModel
    {
        public int TotalPlayers { get; set; }
        public IList<int> CardValues { get; set; }

        public GameModel(IList<int> cardValues)
        {
            CardValues = cardValues;
        }
    }
}

    