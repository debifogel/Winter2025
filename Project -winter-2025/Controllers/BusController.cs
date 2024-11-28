using Buses.Core.classes;
using Buses.Service;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project__winter_2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private  readonly BusService _context;
        public BusController(BusService context)
        {
            _context = context;
        }
        //צריך לחשוב איך לעשות את זה
        // GET: api/<BusController>
        //[HttpGet]
        //public IEnumerable<Bus> Get()
        //{
        //    return _context. buses;
        //}

        // GET api/<BusController>/5


        [HttpGet]
        public IEnumerable<object>? Get([FromQuery] string? name, [FromQuery] CompanyName? company, [FromQuery] string ?destination, [FromQuery] string? source)
        {  
            
                return _context.GetAll().Where(bus =>
                    (bus.BusName == null || bus.BusName == name)
                    && (bus.Company == 0 || bus.Company == company)
                     && (destination == null || bus.Destination == destination)
                && (destination == null || bus.Source == source));
            
        }
       

        // POST api/<BusController>
        [HttpPost]
        public void Post([FromBody] Busfrombody bus)
        {
            Bus b = new Bus();

            b.BusName = bus.BusName;
            b.Source = bus.source;
            b.Destination = bus.destination;
            b.Company = bus.Company;


            _context. buses.Add(b);
        }

        // PUT api/<BusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]  Busfrombody bus)
        {

        }

        // DELETE api/<BusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
