using FirstAPI.Models;
using FirstAPI.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository _repository;

        public EmployeeController(EmployeeRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            return await _repository.GetAll();
        }

        // GET api/Employee/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            var response = await _repository.GetById(id);
            if (response == null) { return NotFound(); }
            return response;
        }

        // POST api/Employee
        [HttpPost]
        public async Task Post([FromBody] Employee data)
        {
            await _repository.InsUp(data);
        }

        // DELETE api/Employee/1
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repository.DeleteById(id);
        }

        [HttpGet("GetName")]
        public async Task<ActionResult<Employee>> GetName(string name)
        {
            var response = await _repository.GetByName(name);            
            return response;
        }
    }
}
