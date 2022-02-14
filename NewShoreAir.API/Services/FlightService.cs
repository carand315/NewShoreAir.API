using NewShoreAir.Business.Models;
using NewShoreAir.DataAccess.UoW;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShoreAir.API.Services
{
    public class FlightService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FlightService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<string>> GetAllOriginCodes()
        {
            return _unitOfWork.FlightRepository.GetAllOriginCodes();
        }

        public Task<List<string>> GetAllDestinationCodes()
        {
            return _unitOfWork.FlightRepository.GetAllDestinationCodes();
        }

        public Task<List<Journey>> GetAllFlights(
            string origin,
            string destination,
            int deep = 3)
        {
            return GetAllFlightsRecursive(
                  origin,
                  destination,
                  deep,
                  new List<Flight>(),
                  new List<Flight>()
                  );
        }

        //Warning: This is a recursive function, be careful!!!
        private async Task<List<Journey>> GetAllFlightsRecursive(
            string origin,
            string finalDestination,
            int deep,
            List<Flight> chainFlights,
            List<Flight> excludedFlights)
        {
            var flights = await _unitOfWork.FlightRepository.GetByOrigin(origin);
            var validFlightsDeep = new List<Journey>();

            for (int i = 0; i < flights.Count; i++)
            {
                var destinationFlight = flights[i];

                if (destinationFlight.Destination.Equals(finalDestination))
                {

                    var valid = chainFlights.Append(destinationFlight).ToList();

                    var journey = new Journey()
                    {
                        Origin = valid[0].Origin,
                        Destination = finalDestination,
                        Flights = valid
                    };

                    journey.CalculateTotal();

                    validFlightsDeep.Add(journey);

                    continue;
                }

                if (excludedFlights.Any(ex => ex.Origin.Equals(destinationFlight.Destination)))
                {
                    continue;
                }

                if (deep > 0)
                {
                    // Recursive Call
                    validFlightsDeep = validFlightsDeep.Concat(
                        await GetAllFlightsRecursive(
                            destinationFlight.Destination,
                            finalDestination,
                            deep-1,
                            chainFlights.Append(destinationFlight).ToList(),
                            excludedFlights.Append(destinationFlight).ToList()))
                      .ToList();
                }
            }

            return validFlightsDeep;
        }
    }
}
