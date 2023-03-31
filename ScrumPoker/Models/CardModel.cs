using System;
namespace ScrumPoker.Models
{
    public class CardModel
    {
        public int CardValue { get; set; }
        public bool MyCard { get; set; } = false;

        public CardModel(int cardValue)
        {
            CardValue = cardValue;
        }
    }
}

