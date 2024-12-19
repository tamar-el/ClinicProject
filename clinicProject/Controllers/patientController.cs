using clinicProject.core.Servises;
using clinicProject.core.Entities;
using Microsoft.AspNetCore.Mvc;
using clinicProject.service;
using AutoMapper;

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
        public IEnumerable<ClassPatient> Get()
        {
            return _PatientServise.GetClassdPatient();
        }

        // GET api/<patientController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<patientController>
        [HttpPost]
        public ClassPatient Post([FromBody] ClassPatient value)
        {
            _PatientServise.AddPatient(value);
            return value;
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
