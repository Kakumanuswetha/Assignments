using Microsoft.EntityFrameworkCore;

namespace Day4_Assignment.Models
{
    public class Product
    {
        public int ProductId { get; set; } 
        public string ProductName { get; set; }
        public double UnitPrice {  get; set; }
        public int Quantity { get; set; }
    }
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) 
        { 

        }
    }
}
