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
        public IEnumerable<object> Get([FromQuery] string name=null, [FromQuery] string company=null, [FromQuery] string destination=null, [FromQuery] string source=null)
        {   List<Bus>list=null;
        
                list= (List<Bus>)buses.Where(bus=>bus.BusName==name);
            if(company != null )
                    if(list != null)
                list= (List<Bus>)list.Where(bus => bus.Company == company);
                   else
                    list = (List<Bus>)buses.Where(bus => bus.Company == company);
            if (destination != null)
                if (list != null)
                    list = (List<Bus>)list.Where(bus => bus.Destination == destination);
                else
                    list = (List<Bus>)buses.Where(bus => bus.Destination == destination);
            if (destination != null)
                if (list != null)
                    list = (List<Bus>)list.Where(bus => bus.Source == source);
                else
                    list = (List<Bus>)buses.Where(bus => bus.Source == source);

            if(list != null)
                return list;
            return buses;
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
            
            
            buses.Add(b);
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
