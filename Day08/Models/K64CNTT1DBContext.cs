using Microsoft.EntityFrameworkCore;

namespace Day08.Models
{
    public class K64CNTT1DBContext:DbContext
    {
        public K64CNTT1DBContext(DbContextOptions options):base(options) 
        { 
        
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
