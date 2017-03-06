using Microsoft.EntityFrameworkCore; 
using FisherInsuranceApi.Models; 

namespace FisherInsuranceApi.Data 
{ public class FisherContext : DbContext 
   {
        internal object Quote;
        internal object Claim;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
     { string connection = "User ID=Keasen;Password=123;Host=localhost;Port=5432;Database=<Fisher-Insurance>;Pooling=true;"; 
     optionsBuilder.UseNpgsql(connection); 
     }
    public DbSet<Claim> Claims { get; set; }
    public DbSet<Quote> Quotes { get; set; }

   } 
   


}