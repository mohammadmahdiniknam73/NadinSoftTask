using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NadinSoft.Domain.Products;
using NadinSoft.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadinSoft.Infrastructure.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).HasConversion(
                productId => productId.Value,
                value => new ProductId(value));

            builder.Property(p => p.ProduceDate).IsRequired();
            builder.HasIndex(p => p.ProduceDate).IsUnique();

            builder.Property(p => p.ManufactureEmail).IsRequired();
            builder.HasIndex(p => p.ManufactureEmail).IsUnique();

            builder.Property(p => p.ManufacturePhone).IsRequired();

            builder.Property(p => p.IsAvailable).IsRequired();

          builder.HasOne<User>().WithMany().HasForeignKey(u=>u.Id).IsRequired;
        }
    }
}
