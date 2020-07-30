using MyRadio.Core.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace MyRadio.Core.Services
{
        public interface IStationRepository
        {
            Station Add(Station station);
            Station Update(Station station);
            Station Get(int id);
            IEnumerable<Station> GetAll();
            void Remove(int id);
        }
    
}
