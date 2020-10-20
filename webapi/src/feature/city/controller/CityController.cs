using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using webapi.src.core.database;
using webapi.src.core.noparam;
using webapi.src.feature.todo.domain.entity;
using webapi.src.feature.todo.domain.usecase;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.src.feature.city.controller
{
    [Route("api/city")]
    [ApiController]
    public class CityController : ControllerBase
    {
        // GET: api/<CityController>

        private readonly GetCitiesUseCase getCitiesUseCase;

        public CityController(GetCitiesUseCase getCitiesUseCase)
        {
            this.getCitiesUseCase = getCitiesUseCase;
        }


        [HttpGet]
        public  IEnumerable<City> Get()
        {
            var cities =  getCitiesUseCase.execiute(new NoParams());
            return cities.Result.second;
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
