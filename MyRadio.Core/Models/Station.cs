using System;
using System.Collections.Generic;
using System.Text;

namespace MyRadio.Core.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Frequency { get; set; }
        public string CallSign { get; set; }
        public string Genre { get; set; }
        public string Website { get; set; }
    }
}
