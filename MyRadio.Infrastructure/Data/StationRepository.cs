using Microsoft.EntityFrameworkCore;
using MyRadio.Core.Models;
using MyRadio.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRadio.Infrastructure.Data
{
    public class StationRepository : IStationRepository
    {
        private readonly AppDbContext _dbContext;
        public StationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Station Add(Station station)
        {
            _dbContext.Stations.Add(station);
            _dbContext.SaveChanges();
            return station;
        }

        public Station Get(int id)
        {
            return _dbContext.Stations
               .SingleOrDefault(b => b.Id == id);
        }

        public IEnumerable<Station> GetAll()
        {
            return _dbContext.Stations
                   .ToList();
        }

        public void Remove(int id)
        {
            var currentStation = _dbContext.Stations.FirstOrDefault(b => b.Id == id);
            if (currentStation != null)
            {
                _dbContext.Stations.Remove(currentStation);
                _dbContext.SaveChanges();
            }
        }

        public Station Update(Station station)
        {
            var currentStation = _dbContext.Stations.Find(station.Id);
            if (currentStation == null) return null;
            _dbContext.Entry(currentStation)
               .CurrentValues
               .SetValues(station);
            _dbContext.Stations.Update(currentStation);
            _dbContext.SaveChanges();
            return currentStation;
        }
    }
}
