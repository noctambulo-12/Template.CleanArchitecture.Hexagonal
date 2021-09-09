using Microsoft.EntityFrameworkCore;
using Template.Domain.Models.Entities;
using Template.Infrastructure.Configs;

namespace Template.Infrastructure.Context
{
    public  class TemplateDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductComponent> ProductComponents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=[datasource];Initial Catalog=[bd];Persist Security Info=True;User ID=[user];Password=[password]");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new ProductComponentConfig());

        }
    }
}
