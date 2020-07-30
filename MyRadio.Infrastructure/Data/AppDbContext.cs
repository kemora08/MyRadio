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
            myBuilder.UseSqlite("Data Source=../MyRadio.Infrastructure/Stations.db");
        }

        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);

            myModelBuilder.Entity<Station>().HasData(
                new Station { Id = 1, Frequency = "93.7", CallSign = "KHBK", Genre = "Top 40", Website = "HOT 93-7.com" }
                );
        }
    }
}
