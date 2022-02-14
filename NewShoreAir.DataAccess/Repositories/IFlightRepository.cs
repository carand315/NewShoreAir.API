using NewShoreAir.Business.Models;
using NewShoreAir.DataAccess.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewShoreAir.DataAccess.Repositories
{
    public interface IFlightRepository : IRepositoryBase<Flight>
    {
        Task<List<Flight>> GetByOrigin(string origin);
        Task<List<string>> GetAllOriginCodes();
        Task<List<string>> GetAllDestinationCodes();
    }
}
