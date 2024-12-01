using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Product_API.Entities;
using System.Numerics;

namespace Product_API.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        { 
        }
        public DbSet<Product> products { get; set; }
    }
}
