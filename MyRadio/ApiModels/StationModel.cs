using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRadio.ApiModels
{
    public class StationModel
    {
        public int Id { get; set; }
        public string Frequency { get; set; }
        public string CallSign { get; set; }
        public string Genre { get; set; }
        public string Website { get; set; }
    }
}
