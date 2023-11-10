using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            builder.Property(u=>u.Id).HasConversion(
                userId => userId.Value,
                value => new UserId(value)).IsRequired();

            builder.Property(u=>u.UserName).IsRequired();
            builder.HasAlternateKey(u => u.UserName);

            builder.Property(u=>u.Password).IsRequired();
        }
    }
}
