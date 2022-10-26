using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Drawing;

namespace ProductData
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext()
        {
        }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Colour> colours { get; set; }
        public DbSet<Article> articles { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Sizes> sizes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2159;Initial Catalog=ProductDb;Integrated Security=True;");
        }
    }
}
