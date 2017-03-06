using System;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoController.Controllers {

[Route("api/quotes")] 
public class QuoteController : Controller { 
    private readonly FisherContext db;

        public QuoteController(FisherContext context)
         {
            db=context;
       
         }
     [HttpGet] public IActionResult GetQuotes() 
     { return Ok(db.Quotes); }

     [HttpGet("{id}", Name = "GetQuotes")] public IActionResult Get(int id) 
     { return Ok(db.Quotes.Find(id)); }

     [HttpPost] public IActionResult Post([FromBody] Quote quote) 
     { 
         var newClaim = db.Quotes.Add(quote); db.SaveChanges(); 
         return CreatedAtRoute("GetQuotes", new { id = quote.Id }, quote); }

    [HttpPut("{id}")] public IActionResult Put(int id, [FromBody] Quote quote) 
    { 
        var newQuote = db.Quotes.Find(id); 
        if (newQuote == null) { return NotFound(); } 
        newQuote = quote; db.SaveChanges(); return Ok(newQuote);
    }

    [HttpDelete("{id}")] public IActionResult Delete(int id) {
         var quoteToDelete = db.Quotes.Find(id); if (quoteToDelete == null) 
         { return NotFound(); } 
         db.Quotes.Remove(quoteToDelete); 
         db.SaveChangesAsync(); 
         return NoContent();

                                                              }
               }
}