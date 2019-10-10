using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lufthavn.Models
{
    public class Flight
    {
        public int FlightID { get; set; }
        public string AircaftType { get; set; }

        [Display(Name = "From")]
        public string FromLocation { get; set; }

        [Display(Name = "To")]
        public string ToLocation { get; set; }

        [Display(Name ="Departure Time")]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; }

        [Display(Name = "Arrival Time")]
        [DataType(DataType.Time)]
        public DateTime ArrivalTime { get; set; }

    }
}
