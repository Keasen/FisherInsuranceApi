using Microsoft.AspNetCore.Mvc;
namespace ClaimsController.Controllers {
[Route("api/Claims/quotes")] 
public class ClaimsController : Controller { 
    [HttpPost] 
    public IActionResult Post([FromBody]string value) { 
        return Created("", value); }
    
    [HttpGet("{id}")] 
    public IActionResult Get(int id) { 
        return Ok("The id is: " + id); }

    [HttpPut("{id}")] 
    public IActionResult Put(int id, [FromBody]string value) { 
        return NoContent(); }

    [HttpDelete("{id}")] 
    public IActionResult Delete(int id) { 
        return Delete(id); }
}
}