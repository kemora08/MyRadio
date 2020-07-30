using MyRadio.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRadio.Core.Services
{
    public class StationService : IStationService
    {
        private readonly IStationRepository _stationRepository;

        public StationService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }
        public Station Add(Station newStation)
        {
            return _stationRepository.Add(newStation);
        }

        public Station Update(Station updatedStation)
        {
            return _stationRepository.Update(updatedStation);
        }

        public Station Get(int id)
        {

            return _stationRepository.Get(id);
        }

        public IEnumerable<Station> GetAll()
        {
            return _stationRepository.GetAll();
        }

        public void Remove(int id)
        {
            _stationRepository.Remove(id);
        }
    }
}
