using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = new()
    {
        new Employee
        {
            Id = 1,
            Name = "John",
            Salary = 60000,
            Permanent = true
        },

        new Employee
        {
            Id = 2,
            Name = "David",
            Salary = 50000,
            Permanent = false
        },

        new Employee
        {
            Id = 3,
            Name = "Sara",
            Salary = 70000,
            Permanent = true
        }
    };

    [HttpPut("{id}")]
    public ActionResult<Employee> UpdateEmployee(
        int id,
        [FromBody] Employee employee)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var existingEmployee =
            employees.FirstOrDefault(e => e.Id == id);

        if (existingEmployee == null)
        {
            return BadRequest("Invalid employee id");
        }

        existingEmployee.Name = employee.Name;
        existingEmployee.Salary = employee.Salary;
        existingEmployee.Permanent = employee.Permanent;

        return Ok(existingEmployee);
    }
}
