using System;
namespace ScrumPoker.Models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public PlayerCardModel Card { get; set; }
        
        public PlayerModel(string name, int cardValue)
        {
            Name = name;
            Card = new PlayerCardModel(name, cardValue);
        }
    }
}

