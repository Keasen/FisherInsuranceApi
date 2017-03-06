using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace ClaimsController.Controllers {
[Route("api/Claims")] 
public class ClaimsController : Controller { 
        private readonly FisherContext db;
    public ClaimsController(FisherContext context)
      {
      db = context;
      }
    
    [HttpPost] 
    public IActionResult Post([FromBody] Claim claim) { 
        var newClaim = db.Claims.Add(claim); 
        db.SaveChanges(); 
        return CreatedAtRoute("GetClaim", new { id = claim.Id }, claim); }
    
    [HttpGet("{id}", Name = "GetClaim")] 
    public IActionResult Get(int id) 
    { 
        return Ok(db.Claims.Find(id)); 
        }

    [HttpGet]
    public IActionResult GetClaims() 
    { return Ok(db.Claims); }

    [HttpPut("{id}")] 
    public IActionResult Put(int id, [FromBody] Claim claim) { 
        var newClaim = db.Claims.Find(id); if (newClaim == null) 
        { return NotFound(); } 
        newClaim = claim; 
        db.SaveChanges(); 
        return Ok(newClaim); }

    [HttpDelete("{id}")] 
    public IActionResult Delete(int id) 
    { var claimToDelete = db.Claims.Find(id); 
    if (claimToDelete == null) { return NotFound(); } 
    
    db.Claims.Remove(claimToDelete); 
    
    db.SaveChangesAsync(); 
    return NoContent(); }
}
}