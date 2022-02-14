using NewShoreAir.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoreAir.DataAccess.UoW
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IFlightRepository FlightRepository { get; }
    }
}
