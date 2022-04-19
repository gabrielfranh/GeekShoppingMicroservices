using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Name2",
                Price = new decimal(50.00),
                Description = "Description2",
                ImageUrl = "",
                CategoryName = "T-shirt2"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name3",
                Price = new decimal(60.00),
                Description = "Description3",
                ImageUrl = "",
                CategoryName = "T-shirt3"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Name4",
                Price = new decimal(70.00),
                Description = "Description4",
                ImageUrl = "",
                CategoryName = "T-shirt4"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Name5",
                Price = new decimal(80.00),
                Description = "Description5",
                ImageUrl = "",
                CategoryName = "T-shirt5"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Name6",
                Price = new decimal(90.00),
                Description = "Description6",
                ImageUrl = "",
                CategoryName = "T-shirt6"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Name",
                Price = new decimal(50.00),
                Description = "Description",
                ImageUrl = "",
                CategoryName = "T-shirt"
            });
        }
    }
}
