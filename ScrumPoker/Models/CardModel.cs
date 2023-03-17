using System;
namespace ScrumPoker.Models
{
    public class CardModel
    {
        public int Value { get; set; }

        public CardModel(int value)
        {
            Value = value;
        }
    }
}

