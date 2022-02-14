using Microsoft.EntityFrameworkCore;
using NewShoreAir.Business.Models;
using NewShoreAir.DataAccess.Base;
using NewShoreAir.DataAccess.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShoreAir.DataAccess.Repositories
{
    public class FlightRepository : RepositoryBase<Flight>, IFlightRepository
    {
        public FlightRepository(NewShoreAirContext context) : base(context)
        {

        }

        public Task<List<string>> GetAllOriginCodes()
        {
            return Context.Flights.Select(x => x.Origin).Distinct().ToListAsync();
        }

        public Task<List<string>> GetAllDestinationCodes()
        {
            return Context.Flights.Select(x => x.Destination).Distinct().ToListAsync();
        }

        public Task<List<Flight>> GetByOrigin(string origin)
        {
            return GetByCondition(f => f.Origin.Equals(origin))
                    .Include(i => i.Transport)
                    .Select(x => new Flight() { 
                        Id= x.Id,
                        Origin = x.Origin,
                        Destination = x.Destination,
                        Price = x.Price,
                        Transport = x.Transport,
                       
                    })
                    .ToListAsync();
        }
    }
}
