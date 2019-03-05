using System;
using Microsoft.AspNetCore.Mvc;

// TODO clean up: remove unused methods
namespace BerthaWristbandRESTprovider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WristbandDataController : ControllerBase
    {
        private static int nextId = 1;
        private static Random random = new Random();
        private static int deviceId = random.Next();

        // GET: api/WristbandData
        [HttpGet]
        public Measurement Get()
        {
            Measurement m = new Measurement()
            { // TODO data relative to former measurement
                DeviceId = deviceId,
                Pm25 = random.Next(50, 120) / 10.0,
                Pm10 = random.Next(100, 500) / 10.0,
                Co2 = random.Next(400, 500),
                O3 = random.Next(200000, 300000),
                Pressure = random.Next(100000, 105000) / 100.0,
                Humidity = random.Next(20, 100),
                Temperature = random.Next(-2000, 5000) / 100.0   
            };
            return m;
        }

        // GET: api/WristbandData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WristbandData
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/WristbandData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
