using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zombie.Models
{
    public class Ranking
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " Username cannot blank")] public string UserName { get; set; }
        [Required] public float SurvivalTime { get; set; }


    }
}