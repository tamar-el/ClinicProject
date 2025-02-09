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
            

            return Ok(await _DoctorServise.AddDoctorAsync(_Mapper.Map<ClassDoctor>(value)));
        }

      


        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] DoctorModel value)
        {

            await _DoctorServise.PutAsync(id, _Mapper.Map<ClassDoctor>(value));
        }


        // DELETE api/<doctorController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
           
            bool isDeleted = await _DoctorServise.DeleteIdAsync(id);
            if (isDeleted)
            {
                return Ok($"doctor with ID {id} deleted successfully.");
            }
            else
            {
                return NotFound($"doctor with ID {id} does not exist.");
            }
        }
    }
}
