using clinicProject.core.Servises;
using clinicProject.core.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
       private IroutesSrevise _RoutesServise;
        public RoutesController(IroutesSrevise routesServise)
        {
            _RoutesServise = routesServise;
        }
        // GET: api/<RoutesController>
        [HttpGet]
        public  IEnumerable<ClassRoute> Get()
        {
            return _RoutesServise.GetClassRoutes();
        }

        // GET api/<RoutesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<RoutesController>
        [HttpPost]
        public ClassRoute Post([FromBody] ClassRoute value)
        {
            _RoutesServise.AddRoutes(value);
            return value;
        }

        // PUT api/<RoutesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClassRoute value)
        {
            var index = _RoutesServise.GetClassRoutes().FindIndex(x => x.id == id);
            _RoutesServise.GetClassRoutes()[index] = value;
        }

        // DELETE api/<RoutesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index= _RoutesServise.GetClassRoutes().FindIndex(x => x.id == id);
            _RoutesServise.GetClassRoutes().RemoveAt(index);
        }
    }
}
