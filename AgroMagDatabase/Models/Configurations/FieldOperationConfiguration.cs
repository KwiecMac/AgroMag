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
    public class FieldOperationConfiguration : IEntityTypeConfiguration<FieldOperation>
    {
        public void Configure(EntityTypeBuilder<FieldOperation> builder)
        {
            builder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(f => f.Contractor)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
