using AgroMagDatabase.Models.Field;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagDatabase.Models.Configurations
{
    public class FieldAddressConfiguration : IEntityTypeConfiguration<FieldAddress>
    {
        public void Configure(EntityTypeBuilder<FieldAddress> builder)
        {
            builder.Property(f => f.City)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(f => f.Street)
                .HasMaxLength(50);

            builder.Property(f => f.ZipCode)
                .HasMaxLength(10);
        }
    }
}
