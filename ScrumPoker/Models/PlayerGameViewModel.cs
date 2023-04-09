using System;
using System.ComponentModel.DataAnnotations;

namespace ScrumPoker.Models
{
    public class PlayerGameViewModel
    {
        [Display(Name = "Player Name")]
        public string? PlayerName { get; set; }

        [Display(Name = "Voting System")]
        public string? VotingSystem { get; set; }
    }
}

