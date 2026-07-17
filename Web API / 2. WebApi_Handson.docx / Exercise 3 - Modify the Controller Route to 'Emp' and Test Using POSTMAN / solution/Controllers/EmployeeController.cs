using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers;

[ApiController]
[Route("api/emp")]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetEmployees()
    {
        var employees = new List<object>
        {
            new
            {
                Id = 101,
                Name = "John",
                Department = "IT"
            },
            new
            {
                Id = 102,
                Name = "David",
                Department = "HR"
            },
            new
            {
                Id = 103,
                Name = "Sara",
                Department = "Finance"
            }
        };

        return Ok(employees);
    }
}
