using System;
namespace ScrumPoker.Models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public PlayerCardModel Card { get; set; }
        public bool SpectatorOnly { get; set; }
        public Guid Id { get; set; }

        public PlayerModel(string name, int cardValue, bool spectatorOnly)
        {
            Name = name;
            Card = new PlayerCardModel(this, cardValue);
            SpectatorOnly = spectatorOnly;
            Id = Guid.NewGuid();
        }
    }
}

