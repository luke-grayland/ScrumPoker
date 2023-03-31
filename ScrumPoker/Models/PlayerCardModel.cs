using System;
namespace ScrumPoker.Models
{
    public class PlayerCardModel : CardModel
    {
        public string Name { get; set; }

        public PlayerCardModel(string name, int cardValue) : base(cardValue)
        {
            Name = name;
        }
    }
}
