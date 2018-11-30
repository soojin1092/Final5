using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Soojin_College_Strike.Models;

namespace Soojin_College_Strike.Data
{
    public class Soojin_College_StrikeContext : DbContext
    {
        public Soojin_College_StrikeContext (DbContextOptions<Soojin_College_StrikeContext> options)
            : base(options)
        {
        }

        public DbSet<Soojin_College_Strike.Models.Assignment> Assignment { get; set; }

        public DbSet<Soojin_College_Strike.Models.Member> Member { get; set; }

        public DbSet<Soojin_College_Strike.Models.Position> Position { get; set; }

        public DbSet<Soojin_College_Strike.Models.Shift> Shift { get; set; }
    }
}
