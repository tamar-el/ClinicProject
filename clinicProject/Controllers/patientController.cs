using clinicProject.core.Servises;
using clinicProject.core.Entities;
using Microsoft.AspNetCore.Mvc;
using clinicProject.service;
using AutoMapper;
using clinicProject.core.DTOs;
using clinicProject.core.DBOs;
using clinicProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class patientController : ControllerBase
    {
       private readonly IpatientSrevise _PatientServise;
        private readonly IMapper _Mapper;
        public patientController(IpatientSrevise PatientServise,IMapper mapper)
        {
            _PatientServise = PatientServise;
            _Mapper = mapper;
        }

        // GET: api/<patientController>
        [HttpGet]
       
        public async Task<ActionResult> Get()
        {
            var list =await  _PatientServise.GetClassdPatientAsync();
            var Ptolist = new List<PatientDto>();
            Ptolist = _Mapper.Map<List<PatientDto>>(list);

            return Ok(Ptolist);
        }

        // GET api/<patientController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var list = await _PatientServise.GetAsync(id);
            var Dtolist = new PatientDto();
            Dtolist = _Mapper.Map<PatientDto>(list);
            return Ok(Dtolist);
        }
        // POST api/<patientController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PatientModel value)
        {
            var newPatient = new ClassPatient {  name = value.name,age=value.age,address=value.address, phone = value.phone, email = value.email };

            return Ok(await _PatientServise.AddPatientAsync(newPatient));
        }

        // PUT api/<patientController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] PatientModel value)
        {
            var newPatient = new ClassPatient {  name = value.name, age = value.age, address = value.address, phone = value.phone, email = value.email };
            await _PatientServise.PutAsync(id, newPatient);

        }
        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _PatientServise.DeleteIdAsync(id);
        }
    }
}
