using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.Models.Entities;

namespace Template.Infrastructure.Configs
{
    public class ProductComponentConfig : IEntityTypeConfiguration<ProductComponent>
    {
        public void Configure(EntityTypeBuilder<ProductComponent> builder)
        {
            builder.ToTable("ProductComponent");
            builder.HasKey(c => c.ProductComponentId);
        }
    }
}
