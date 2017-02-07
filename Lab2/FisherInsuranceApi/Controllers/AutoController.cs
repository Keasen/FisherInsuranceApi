using Microsoft.AspNetCore.Mvc;
namespace AutoController.Controllers {
[Route("api/auto/quotes")] 
public class AutoController : Controller { 
    [HttpPost("{value}")] 
    public IActionResult Post([FromBody]string value) { 
        return Created("", value); }
    
    [HttpGet("{id}")] 
    public IActionResult Get(int id) { 
        return Ok("The id is: " + id); }

    [HttpPut("{id},{value}")] 
    public IActionResult Put(int id, [FromBody]string value) { 
        return NoContent(); }

    [HttpDelete("{id}")] 
    public IActionResult Delete(int id) { 
        return Delete(id); }
}
}