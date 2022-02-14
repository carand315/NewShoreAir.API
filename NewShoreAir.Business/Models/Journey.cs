using NewShoreAir.Business.Base;
using System.Collections.Generic;
using System.Linq;

namespace NewShoreAir.Business.Models
{
    public class Journey : Trip
    {
        public IEnumerable<Flight> Flights { get; set; }    
 
        public Journey()
        {
            Flights = new List<Flight>();
        }

        public void CalculateTotal()
        {
            Price = Flights.ToList().Sum(x => x.Price);
        }

    }
}
