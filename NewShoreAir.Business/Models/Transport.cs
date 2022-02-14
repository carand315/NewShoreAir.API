using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NewShoreAir.Business.Models
{
    public class Transport
    {
        public int Id { get; set; }
        public string FlightCarrier { get; set; }
        public string FlightNumber { get; set; }

        [JsonIgnore]
        public virtual List<Flight> Flights { get; set; }

        public Transport()
        {

        }
    }
}
