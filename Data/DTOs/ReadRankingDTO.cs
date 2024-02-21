using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zombie.Data.DTOs
{
    public class ReadRankingDTO
    {
        public string UserName { get; set; }
        public DateTime searchTime { get; set; } = DateTime.Now;
        [Required] public float SurvivalTime { get; set; }

    }
}