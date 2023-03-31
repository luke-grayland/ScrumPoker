using System;
namespace ScrumPoker.Models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public PlayerCardModel Card { get; set; }
        public bool SpectactorOnly { get; set; }

        public PlayerModel(string name, int cardValue, bool spectactorOnly)
        {
            Name = name;
            Card = new PlayerCardModel(this, cardValue);
            SpectactorOnly = spectactorOnly;
        }
    }
}

