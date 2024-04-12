using Microsoft.AspNetCore.Mvc;
using SensorSimulator;

namespace SensorsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SensorsController : ControllerBase
    {
        [HttpGet("temperature")]
        public ActionResult<double> GetTemperature()
        {
            try
            {
                return Sensors.GetTemperature();
            }
            catch (System.Exception ex)
            {
                return StatusCode(500,$"Error occurred: {ex.Message}");
            }
        }

        [HttpGet("rainfall")]
        public ActionResult<double> GetRainfall()
        {
            try
            {
                return Sensors.GetRainfall();
            }
            catch(System.Exception ex)
            {
                return StatusCode(500,$"Error occurred:{ex.Message}");
            }
        }

        [HttpGet("humidity")]
        public ActionResult<double> GetHumidity()
        {
            try{
                return Sensors.GetHumidity();
            }
            catch(System.Exception ex)
            {
                return StatusCode(500,"error occurred:{ex.Message}");
            }
        }

        [HttpGet("air_pollution")]
        public ActionResult<double> GetAirPollution()
        {
            try
            {
                return Sensors.GetAirPollution();

            }
            catch(System.Exception ex)
            {
                return StatusCode(500,"error occurred:{ex.Message}");
            }
        }

        [HttpGet("co2_emission")]
        public ActionResult<double> GetCO2Emission()
        {
            try{
                return Sensors.GetCO2Emission();
            }
            catch(System.Exception ex)
            {
                return StatusCode(500,"error occurred:{ex.Message}");
            }
        }
    }
}
