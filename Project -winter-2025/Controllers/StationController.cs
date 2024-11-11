using Microsoft.AspNetCore.Mvc;
using Project__winter_2025.data;
using WinterModel.classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project__winter_2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IData _context;
        public StationController(IData context)
        {
            _context = context;
        }

        // GET: api/<StationController>
        [HttpGet]
        public IEnumerable<Station> Get()
        {
            return _context.stations;
        }

        // GET api/<StationController>/5
        [HttpGet("{id}")]
        public ActionResult<Station> Get(int id)
        {
            
            Station s= _context.stations.Find(stop=>stop.Id==id);
            if (s is null)
            {
                return NotFound();
            }
            return Ok(s);
        }

        // POST api/<StationController>
        [HttpPost]
        public void Post([FromBody] NameAndCity value)
        {
            _context.stations.Add(new Station(value.Name, value.City));
        }

        // PUT api/<StationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Bus value)
        {
            _context.stations.Find(stop => stop.Id == id).BusInStation.Add(value);
        }

        // DELETE api/<StationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

       
    }
}
