using NewShoreAir.DataAccess.Common;
using NewShoreAir.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreAir.DataAccess.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NewShoreAirContext _context;
        private IFlightRepository flightRepository;

        public UnitOfWork(NewShoreAirContext context)
        {
            _context = context;
        }

        public IFlightRepository FlightRepository => flightRepository ??= new FlightRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
