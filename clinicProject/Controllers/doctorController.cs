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
            _Mapper = mapper;
        }


        // GET: api/<doctorController>
        [HttpGet]
       
        public async Task<ActionResult> Get()
        {
            var list = await _DoctorServise.GetClassDoctorsAsync();
            var Dtolist = new List<DoctorDto>();
            Dtolist = _Mapper.Map<List<DoctorDto>>(list);

            return Ok(Dtolist);
        }

        // GET api/<doctorController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var list = await _DoctorServise.GetAsync(id);
            var Dtolist = new DoctorDto();
            Dtolist = _Mapper.Map<DoctorDto>(list);
            return Ok(Dtolist);
        }

        // POST api/<doctorController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DoctorModel value)
        {
            var newDoctor = new ClassDoctor { id = value.id, name = value.name, phone = value.phone, email = value.email };

            return Ok(await _DoctorServise.AddDoctorAsync(newDoctor));
        }

        // PUT api/<doctorController>/5
        //[HttpPut("{id}")]
        //public async Task<ClassDoctor> Put(int id, [FromBody] ClassDoctor value)
        //{
        //    var doctors = await _DoctorServise.GetClassDoctorsAsync();
        //    var index = doctors.FindIndex(x => x.id == id);
        //    var getD=await _DoctorServise.GetClassDoctorsAsync();
        //    getD[index] = value;
        //    return value;

        //}


        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] DoctorModel value)
        {
            var newDoctor = new ClassDoctor {  name = value.name, phone = value.phone, email = value.email };
            await _DoctorServise.PutAsync(id, newDoctor);
          
        }


        // DELETE api/<doctorController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
           return await _DoctorServise.DeleteIdAsync(id);
        }
    }
}
