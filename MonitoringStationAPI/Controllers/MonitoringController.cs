using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MonitoringStationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonitoringController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public MonitoringController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet("collect_data")]
        public async Task<IActionResult> CollectData()
        {
            try
            {
                var client = _clientFactory.CreateClient();

                var endpoints = new string[]
                {
                    "http://localhost:5001/temperature",
                    "http://localhost:5001/rainfall",
                    "http://localhost:5001/humidity",
                    "http://localhost:5001/air_pollution",
                    "http://localhost:5001/co2_emission"
                };

                foreach (var endpoint in endpoints) // Corrected 'iun' to 'in'
                {
                    var response = await client.GetAsync(endpoint); // Use 'endpoint' instead of 'endpoints'
                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                    }
                    else 
                    {
                        return StatusCode((int)response.StatusCode, $"Data not found at endpoint: {endpoint}"); // Use 'endpoint' instead of 'endpoints'
                    }
                }
                return Ok("Fetched data from all endpoints successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
