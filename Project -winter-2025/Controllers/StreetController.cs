using Microsoft.AspNetCore.Mvc;
using Project__winter_2025.classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project__winter_2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreetController : ControllerBase
    {
        List<Street> streets = new List<Street>();
        // GET: api/<StreetController>
        [HttpGet]
        public IEnumerable<Street> Get()
        {
            return streets;
        }

        // GET api/<StreetController>/5

        //צריך לחשוב איך לעשות את זה 
        [HttpGet("{id}")]
        public Street Get(string city,string nameofstreet)
        {
            try
            {
                return streets.Find(street => street.Name == nameofstreet && street.City == city);
            }
            catch{ return null; }
        }

        // POST api/<StreetController>
        [HttpPost]
        public void Post([FromBody]NameAndCity value)

        {
            streets.Add(new Street (  value.Name,  value.City ));
        }

        // PUT api/<StreetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Station station)
        {
            streets.Find(street=>street.Id==id).ListOfStation.Add(station);
        }

        // DELETE api/<StreetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
