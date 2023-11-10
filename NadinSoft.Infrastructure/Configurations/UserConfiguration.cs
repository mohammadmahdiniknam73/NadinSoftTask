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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(u=>u.Id).HasConversion(
                userId => userId.Value,
                value => new UserId(value)).IsRequired();

            builder.Property(u=>u.UserName).HasMaxLength(50);
            builder.HasIndex(u => u.UserName).IsUnique();

            builder.Property(u=>u.Password).HasMaxLength(16).IsRequired();

            builder.HasMany<Product>().WithOne().IsRequired();
        }
    }
}
