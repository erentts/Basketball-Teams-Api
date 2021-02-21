using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballTeamsApi.Core.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TeamId { get; set; }
        public int JerseyNumber { get; set; }
        public decimal AveragePoints { get; set; }
        public decimal AverageAssist { get; set; }
        public decimal AverageRebound { get; set; }
        public virtual Team Team { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}
