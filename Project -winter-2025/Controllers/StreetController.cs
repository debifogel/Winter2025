using Microsoft.AspNetCore.Mvc;
using Project__winter_2025.data;
using WinterModel.classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project__winter_2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreetController : ControllerBase
    {
        private readonly IData _context;
        public StreetController(IData context)
        {
            _context = context;
        }
        // GET: api/<StreetController>
        [HttpGet]
        public IEnumerable<Street> Get()
        {
            return _context.streets;
        }

        // GET api/<StreetController>/5

        //צריך לחשוב איך לעשות את זה 
        [HttpGet("{id}")]
        public Street Get(string city,string nameofstreet)
        {
              
                return _context.streets.FirstOrDefault(street => street.Name == nameofstreet && street.City == city);
            
           
        }

        // POST api/<StreetController>
        [HttpPost]
        public void Post([FromBody]NameAndCity value)

        {
            _context. streets.Add(new Street (  value.Name,  value.City ));
        }

        // PUT api/<StreetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Station station)
        {
            _context. streets.Find(street=>street.Id==id).ListOfStation.Add(station);
        }

        // DELETE api/<StreetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
