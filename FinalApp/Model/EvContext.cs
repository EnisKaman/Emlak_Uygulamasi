using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Model
{
    public class EvContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Ev> Evler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\MSSQLSERVER19;Initial Catalog=OkulDb;User=sa;Password=enes3349.");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("tblUsers");
            modelBuilder.Entity<User>().Property(u=>u.Username).HasColumnType("varchar").HasMaxLength(30);

            modelBuilder.Entity<Ev>().ToTable("tblEvler");
            modelBuilder.Entity<Ev>().Property(e=>e.Semt).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
