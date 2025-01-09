                                                                                  using clinicProject.core.Servises;
using clinicProject.core.Entities;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using clinicProject.core.DTOs;
using clinicProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class doctorController : ControllerBase
    {
        private IdoctorServise _DoctorServise;
        private readonly IMapper _Mapper;
        public doctorController(IdoctorServise doctorServise, IMapper mapper)
        {
            _DoctorServise = doctorServise;
            _Mapper=mapper;
        }

       
        // GET: api/<doctorController>
        [HttpGet]
        //public IEnumerable<ClassDoctor> Get()
        //{
        //    return _DoctorServise.GetClassDoctors();
        //}
        public ActionResult Get()
        {
            var list = _DoctorServise.GetClassDoctors();
            var Dtolist = new List<DoctorDto>();
            Dtolist = _Mapper.Map<List<DoctorDto>>(list);

            return Ok(Dtolist);
        }

        // GET api/<doctorController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<doctorController>
        [HttpPost]
        public ActionResult Post([FromBody] DoctorModel value)
        {
            var newDoctor=new ClassDoctor {id= value.id,name=value.name,phone=value.phone,email=value.email};
            
            return Ok(_DoctorServise.AddDoctor(newDoctor) );
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
