using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace FisherInsuranceApi.Data 
{ 
    
   public class FisherContext : IdentityDbContext<ApplicationUser> {
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            string connection = "User ID=Keasen;Password=123;Host=localhost;Port=5432;Database=<Fisher-Insurance>;Pooling=true;";  
            optionsBuilder.UseNpgsql(connection); 
        }
    }    
}