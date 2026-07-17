using EmployeeAPI.Filters;
using EmployeeAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[CustomAuthFilter]
public class EmployeeController : ControllerBase
{
    private readonly List<Employee> employees;

    public EmployeeController()
    {
        employees = GetStandardEmployeeList();
    }

    private List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>();
    }

    [AllowAnonymous]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Employee>> GetStandard()
    {
        return Ok(employees);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Employee employee)
    {
        employees.Add(employee);

        return Ok(employee);
    }

    [HttpPut]
    public IActionResult Put([FromBody] Employee employee)
    {
        return Ok(employee);
    }
}
