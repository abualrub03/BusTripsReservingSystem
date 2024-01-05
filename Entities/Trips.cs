using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Trips
    {
        public int TripId { get; set; }
        public string  TripGoingFrom { get; set; }

        public string TripDestination { get; set; }

        public DateTime StartDateAndTime { get; set; }

        public DateTime EndDateAndTime { get; set; }

        public string TripName { get; set; }

    }
}
