using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyRadio.Core.Models;

namespace MyRadio.ApiModels
{
    public static class StationMappingExtensions
    {
        public static StationModel ToApiModel(this Station station)
        {
            return new StationModel
            {
                //TODO: Map domain properties to equivalent ApiModels properties
                //ID
                //Frequency
                //CallSign
                //Genre
                //Website
                Id = station.Id,
                Frequency = station.Frequency,
                CallSign = station.CallSign,
                Genre = station.Genre,
                Website = station.Website,

            };
        }

        public static Station ToDomainModel(this StationModel stationModel)
        {
            return new Station
            {
                Id = stationModel.Id,
                Frequency = stationModel.Frequency,
                CallSign = stationModel.CallSign,
                Genre = stationModel.Genre,
                Website = stationModel.Website,
            };
        }

        public static IEnumerable<StationModel> ToApiModels(this IEnumerable<Station> stations)
        {
            return stations.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Station> ToDomianModel(this IEnumerable<StationModel> stationModel)
        {
            return stationModel.Select(a => a.ToDomainModel());
        }
    }
}
