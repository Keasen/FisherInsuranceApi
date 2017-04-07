using Microsoft.EntityFrameworkCore; 
using FisherInsuranceApi.Models; 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace FisherInsuranceApi.Data 
{ 
    
    public class FisherContext : IdentityDbContext<Applicationuser> {
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            string connection = "User ID=keasen;Password=123;Host=localhost;Port=5433;Database=fisher-insurance;Pooling=true;"; 
            optionsBuilder.UseNpgsql(connection); 
        }
    }    
}