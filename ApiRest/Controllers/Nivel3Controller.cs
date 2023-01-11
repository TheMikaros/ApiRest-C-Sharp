using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Nivel3Controller : ControllerBase
    {
        // GET: api/Nivel3
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Nivel3/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Nivel3
        [HttpPost]
        public Appointment Post([FromBody]Appointment value)
        {
            return PostAppointment(new Appointment { });
        }

        // PUT: api/Nivel3/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public Appointment PostAppointment(Appointment appointment)
        {
            appointment = new Appointment
            {
                Date = DateTime.Now,
                Doctor = "Dr. Who",
                Slot = 1234,
                HyperMedia = new List<HyperMedia>
                {
                    new HyperMedia{ Href = "/slot/1234", Rel = "get" },
                    new HyperMedia{ Href = "/slot/1234", Rel = "delete" },
                    new HyperMedia{ Href = "/slot/1234", Rel = "put" },
                }
            };

            return appointment;
        }

    }

    public class Appointment
    {
        [JsonProperty("doctor")]
        public string Doctor { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("links")]
        public List<HyperMedia> HyperMedia { get; set; }
    }

    public class HyperMedia
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
