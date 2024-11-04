using Microsoft.AspNetCore.Mvc;
using Project__winter_2025.classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project__winter_2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        List<Bus> buses = new List<Bus>();
        // GET: api/<BusController>
        [HttpGet]
        public IEnumerable<Bus> Get()
        {
            return buses;
        }

        // GET api/<BusController>/5

        //צריך לחשוב איך לעשות את זה
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        

        // POST api/<BusController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
