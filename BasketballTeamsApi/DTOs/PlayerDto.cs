using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamsApi.DTOs
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TeamId { get; set; }
        public int JerseyNumber { get; set; }
        public decimal AveragePoints { get; set; }
        public decimal AverageAssist { get; set; }
        public decimal AverageRebound { get; set; }
    }
}
