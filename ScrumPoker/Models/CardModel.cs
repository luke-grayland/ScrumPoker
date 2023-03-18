using System;
namespace ScrumPoker.Models
{
    public class CardModel
    {
        public int CardValue { get; set; }
        public bool IsSelected { get; set; }
        public bool IsDisplayed { get; set; }

        public CardModel(int cardValue)
        {
            CardValue = cardValue;
            IsSelected = false;
            IsDisplayed = false;
        }
    }
}

