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
        //public IEnumerable<ClassPatient> Get()
        //{
        //    return _PatientServise.GetClassdPatient();
        //}
        public ActionResult Get()
        {
            var list = _PatientServise.GetClassdPatient();
            var Ptolist = new List<PatientDto>();
            Ptolist = _Mapper.Map<List<PatientDto>>(list);

            return Ok(Ptolist);
        }

        // GET api/<patientController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<patientController>
        [HttpPost]
        public ActionResult Post([FromBody] PatientModel value)
        {
            var newPatient = new ClassPatient { id = value.id, name = value.name,age=value.age,address=value.address, phone = value.phone, email = value.email };

            return Ok(_PatientServise.AddPatient(newPatient));
        }

        // PUT api/<patientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClassPatient value)
        {
            var index = _PatientServise.GetClassdPatient().ToList().FindIndex(x => x.id == id);
            _PatientServise.GetClassdPatient().ToList()[index] = value;
        }

        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index= _PatientServise.GetClassdPatient().ToList().FindIndex(x => x.id==id);
            _PatientServise.GetClassdPatient().ToList().RemoveAt(index);
        }
    }
}
