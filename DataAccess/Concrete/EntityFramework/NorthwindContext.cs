using Entitites.Concrete;
using Entitites.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = True;");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductDetailDto> GetProductDetailDtos { get; set; }
    }
}
//}
//Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
//TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False