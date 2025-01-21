using clinicProject.core.Servises;
using clinicProject.core.Entities;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using clinicProject.core.DBOs;
using clinicProject.service;
using clinicProject.core.DTOs;
using clinicProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinicProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
       private readonly IroutesSrevise _RoutesServise;
        private readonly IMapper _Mapper;
        public RoutesController(IroutesSrevise routesServise,IMapper mapper)
        {
            _RoutesServise = routesServise;
            _Mapper = mapper;
        }
        // GET: api/<RoutesController>
        [HttpGet]
       
        public async Task<ActionResult> Get()
        {
            var list =await  _RoutesServise.GetClassRoutesAsync();
            var Rtolist = new List<RouteDto>();
            Rtolist = _Mapper.Map<List<RouteDto>>(list);

            return Ok(Rtolist);
        }

        // GET api/<RoutesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var list = await _RoutesServise.GetAsync(id);
            var Dtolist = new RouteDto();
            Dtolist = _Mapper.Map<RouteDto>(list);
            return Ok(Dtolist);
        }

        // POST api/<RoutesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RouteModel value)
        {
            var newRoute = new ClassRoute { Date=value.Date,startTime=value.startTime,endTime=value.endTime,Dname=value.Dname };

            return Ok(await _RoutesServise.AddRoutesAsync(newRoute));
        }

        // PUT api/<RoutesController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] RouteModel value)
        {
            var newRoute = new ClassRoute { Date = value.Date, startTime = value.startTime, endTime = value.endTime ,Dname = value.Dname };
            await _RoutesServise.PutAsync(id, newRoute);

        }


        // DELETE api/<RoutesController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _RoutesServise.DeleteIdAsync(id);
        }
    }
}
