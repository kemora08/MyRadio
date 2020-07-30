using MyRadio.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRadio.Core.Services
{
    public interface IStationService
    {
        Station Add(Station newStation);
        Station Update(Station updatedStation);
        Station Get(int id);
        IEnumerable<Station> GetAll();
        void Remove(int id);
    }
}
