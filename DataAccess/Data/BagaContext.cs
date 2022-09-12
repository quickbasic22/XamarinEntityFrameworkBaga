using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class BagaContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=XamarinBaga.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>().Property(d => d.Name).IsRequired();
            modelBuilder.Entity<Destination>().Property(d => d.Description).HasMaxLength(200);
            modelBuilder.Entity<Destination>().Property(d => d.Photo).HasColumnType("image");

            modelBuilder.Entity<Lodging>().Property(l => l.Name).IsRequired().HasMaxLength(200);

            modelBuilder.Entity<ActivityTrips>().HasKey(k => new { k.ActivityId, k.Identifier });
            
           
        }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityTrips> ActivityTrips { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonPhoto> PersonPhotos { get; set; }

    }
}
