using System;
namespace ScrumPoker.Models
{
    public class PlayerCardModel : CardModel
    {
        public PlayerModel Player;

        public PlayerCardModel(PlayerModel player, int cardValue) : base(cardValue)
        {
            Player = player;
        }
    }
}
