using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UTS_Pest_Control.Models;

namespace UTS_Pest_Control.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=db_vb2_pest_control;Username=postgres;Password=945313");
        }
    }
}
