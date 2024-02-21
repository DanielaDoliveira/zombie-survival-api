using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using zombie.Models;

namespace zombie.Data
{
    public class RankingContext : DbContext
    {
        public RankingContext(DbContextOptions<RankingContext> opts) : base(opts)
        {

        }
        public DbSet<Ranking> RankingBoard { get; set; }


    }
}