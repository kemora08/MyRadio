using Microsoft.EntityFrameworkCore;
using MyRadio.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRadio.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Station> Stations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder myBuilder)
        {
            myBuilder.UseSqlite("Data Source=Stations.db");
        }

        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);

            myModelBuilder.Entity<Station>().HasData(
                new Station { Id = 1, Frequency = 93.7, 97.3, 100.7, 106.5, 107.7, and 950, CallSign },
                );
        }
    }
}
