using clinicProject.core.Servises;
using clinicProject.core.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class doctorController : ControllerBase
    {
        private IdoctorServise _DoctorServise;
        public doctorController(IdoctorServise doctorServise)
        {
            _DoctorServise = doctorServise;
        }

       
        // GET: api/<doctorController>
        [HttpGet]
        public IEnumerable<ClassDoctor> Get()
        {
            return _DoctorServise.GetClassDoctors();
        }

        // GET api/<doctorController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<doctorController>
        [HttpPost]
        public ClassDoctor Post([FromBody] ClassDoctor value)
        {
            _DoctorServise.AddDoctor(value);
            return value;
        }

        // PUT api/<doctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClassDoctor value)
        {
            var index= _DoctorServise.GetClassDoctors().ToList().FindIndex(x => x.id==id);
            _DoctorServise.GetClassDoctors().ToList()[index]=value;
        }

        // DELETE api/<doctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index= _DoctorServise.GetClassDoctors().ToList().FindIndex(x=>x.id==id);
            _DoctorServise.GetClassDoctors().ToList().RemoveAt(index);
        }
    }
}
