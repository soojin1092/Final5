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

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Shift> Shifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("STRIKE");

            //Many to Many Primary Key
            modelBuilder.Entity<Member_Position>()
            .HasKey(mp => new { mp.MemberID, mp.PositionID });

            modelBuilder.Entity<Shift>()
            .HasKey(s => new { s.MemberID, s.AssignmentID });

            //Add a unique index to the Position Title
            modelBuilder.Entity<Position>()
            .HasIndex(p => p.Title)
            .IsUnique();

            //Add a unique index to the Member eMail
            modelBuilder.Entity<Member>()
            .HasIndex(m => m.eMail)
            .IsUnique();

            //Add a unique index to the Shift 
            //ShiftDate and MemberID
            modelBuilder.Entity<Shift>()
            .HasIndex(s => new { s.ShiftDate, s.MemberID })
            .IsUnique();

            //Add a unique index to the Assignment AssignmentName
            modelBuilder.Entity<Assignment>()
            .HasIndex(a => a.AssignmentName)
            .IsUnique();


            //Prevent Cascade Delete Assignment to Shift
            modelBuilder.Entity<Assignment>()
                .HasMany<Shift>(p => p.Shifts)
                .WithOne(c => c.Assignment)
                .HasForeignKey(c => c.AssignmentID)
                .OnDelete(DeleteBehavior.Restrict);

            //Prevent Cascade Delete Assignment to Member
            modelBuilder.Entity<Assignment>()
                .HasMany<Member>(p => p.Members)
                .WithOne(c => c.Assignment)
                .HasForeignKey(c => c.AssignmentID)
                .OnDelete(DeleteBehavior.Restrict);

            //Prevent Cascade Delete Member to Shift(Child Perspective)
            modelBuilder.Entity<Shift>()
                .HasOne(c => c.Member)
                .WithMany(p => p.Shifts)
                .HasForeignKey(c => c.MemberID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
