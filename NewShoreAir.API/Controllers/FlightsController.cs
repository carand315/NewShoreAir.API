using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewShoreAir.API.Services;
using NewShoreAir.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewShoreAir.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private ILogger<FlightsController> _logger;
        private FlightService flightService;
        public FlightsController(FlightService _flightService, ILogger<FlightsController> logger)
        {
            flightService = _flightService;
            _logger = logger;
        }

        [HttpGet]
        public Task<List<Journey>> Get(string origin, string destination, int deep)
        {
            _logger.LogInformation($"Trying to get journeys with params {origin}, {destination} & {deep}");

            try
            {
                return flightService.GetAllFlights(origin, destination, deep);               
            }
            catch (System.Exception)
            {
                _logger.LogInformation("An error has occured after trying to get journeys");
                throw new System.Exception("Exception while fetching all journeys.");
            }
            finally {
                _logger.LogInformation("Exiting after trying to get journeys");
            }
        }

        [HttpGet("GetAllOriginCodes")]
        public Task<List<string>> GetAllOriginCodes()
        {
            _logger.LogInformation("Trying to get all origin codes.");

            try
            {
                return flightService.GetAllOriginCodes();
            }
            catch (System.Exception)
            {
                _logger.LogInformation("An error has occured after trying to get all origin codes");
                throw new System.Exception("Exception while fetching all origin codes.");
            }
            finally
            {
                _logger.LogInformation("Exiting after trying to get all origin codes");
            }
        }

        [HttpGet("GetAllDestinationCodes")]
        public Task<List<string>> GetAllDestinationCodes()
        {          

            try
            {
                _logger.LogInformation("Trying to get all destination codes");
                return flightService.GetAllDestinationCodes();
            }
            catch (System.Exception)
            {
                _logger.LogInformation("An error has occured after trying to get all destination codes");
                throw new System.Exception("Exception while fetching all destination codes.");
            }
            finally
            {
                _logger.LogInformation("Exiting after trying to get all destination codes");
            }
        }
    }
}
