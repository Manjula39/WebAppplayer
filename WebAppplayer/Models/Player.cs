using System;
using System.Collections.Generic;

namespace WebAppplayer.Models
{
    public partial class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public double? JerseyNumber { get; set; }
        public int? Position { get; set; }
        public string? TeamName { get; set; }
    }
}
