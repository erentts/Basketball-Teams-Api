using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BasketballTeamsApi.Core.Entities
{
    public class Team
    {
        public Team()
        {
            Players = new Collection<Player>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string CourtName { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Player> Players { get; set; } 
    }
}
