using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCore.Data
{
    public class TransportManagementSystemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=TransportManagementSyatem_EfCore");
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Bus> Buses { get; set; }

        public DbSet<BusRoute> BusRoutes { get; set; }

        public DbSet<Route> Routes { get; set; }

        public DbSet<Trip> Trips { get; set; } 

        public DbSet<UserTrip> UserTrips { get; set; }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18, 2)");
        

            modelBuilder.Entity<Route>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18, 2)");
        }


    }
}
