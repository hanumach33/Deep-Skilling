using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetEmployees()
    {
        return Ok(new[]
        {
            new
            {
                Id = 1,
                Name = "John",
                Department = "IT"
            },
            new
            {
                Id = 2,
                Name = "David",
                Department = "HR"
            }
        });
    }
}
