using Malek_Attempt.BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;
using Malek_Attempt.Models;
using System.Collections.Generic;

namespace Malek_Attempt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        //------------------------------------------------------------------
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return Ok(_employeeService.GetAllEmployees());
        }
        //------------------------------------------------------------------
        [HttpGet("{id}")]
        public ActionResult<Employee> GetById(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null) { return NotFound(); }

            return Ok(employee);
        }
        //------------------------------------------------------------------
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            _employeeService.CreateEmployee(employee);
            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }
        //------------------------------------------------------------------
        [HttpPut("{id}")]
        public ActionResult Update(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }

            _employeeService.UpdateEmployee(employee);
            return NoContent();
        }
        //------------------------------------------------------------------
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
            return NoContent();
        }
        //------------------------------------------------------------------
    }
}
