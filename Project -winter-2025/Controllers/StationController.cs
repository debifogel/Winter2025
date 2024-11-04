using Microsoft.AspNetCore.Mvc;
using Project__winter_2025.classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project__winter_2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        List<Station> stations = new List<Station>();

        // GET: api/<StationController>
        [HttpGet]
        public IEnumerable<Station> Get()
        {
            return stations;
        }

        // GET api/<StationController>/5
        [HttpGet("{id}")]
        public Station Get(int id)
        {
            return stations.Find(stop=>stop.Id==id);
        }

        // POST api/<StationController>
        [HttpPost]
        public void Post([FromBody] NameAndCity value)
        {
            stations.Add(new Station(value.Name, value.City));
        }

        // PUT api/<StationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Bus value)
        {
            stations.Find(stop => stop.Id == id).BusInStation.Add(value);
        }

        // DELETE api/<StationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
