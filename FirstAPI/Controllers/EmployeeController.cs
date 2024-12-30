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
            // return await _repository.GetAll();
            return Ok(new ApiResponse<IEnumerable<Employee>>(
                    success: true,
                    message: "Data retrieved successfully",
                    data: await _repository.GetAll()
                ));
        }

        // GET api/Employee/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            var response = await _repository.GetById(id);
            if (response == null) { return NotFound(); }

            return Ok(new ApiResponse<Employee>(
                    success: true,
                    message: "Data retrieved successfully",
                    data: response
                ));
        }

        // POST api/Employee
        [HttpPost]
        public async Task<OkObjectResult> Post([FromBody] InsOrUpEmployee data)
        {
            await _repository.InsUp(data, 0);

            return Ok(new ApiResponse<string>(
                    success: true,
                    message: "Data inserted successfully",
                    data: null
                ));
        }

        // PUT api/Employee/{id}
        [HttpPut("{id}")]
        public async Task<OkObjectResult> Put([FromBody] InsOrUpEmployee data, int id)
        {
            await _repository.InsUp(data, id);

            return Ok(new ApiResponse<string>(
                    success: true,
                    message: "Data updated successfully",
                    data: null
                ));
        }

        // DELETE api/Employee/{id}
        [HttpDelete("{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            await _repository.DeleteById(id);

            return Ok(new ApiResponse<string>(
                    success: true,
                    message: "Data deleted successfully",
                    data: null
                ));
        }

        // GET api/Employee/GetName?name=example
        [HttpGet("GetName")]
        public async Task<ActionResult<Employee>> GetName(string name)
        {
            var response = await _repository.GetByName(name);            

            return Ok(new ApiResponse<Employee>(
                    success: true,
                    message: "Data retrieved successfully",
                    data: response
                ));
        }
    }
}
