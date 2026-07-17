using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    // GET: api/values
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new string[]
        {
            "Value 1",
            "Value 2",
            "Value 3"
        });
    }

    // GET: api/values/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok($"Value : {id}");
    }

    // POST: api/values
    [HttpPost]
    public IActionResult Post([FromBody] string value)
    {
        return Ok($"Created : {value}");
    }

    // PUT: api/values/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] string value)
    {
        return Ok($"Updated {id} : {value}");
    }

    // DELETE: api/values/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Ok($"Deleted : {id}");
    }
}
