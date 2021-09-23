using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagDatabase.Models.Configurations
{
    public class FieldConfiguration : IEntityTypeConfiguration<Field.Field>
    {
        public void Configure(EntityTypeBuilder<Field.Field> builder)
        {
            builder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(f => f.IsOwn)
                .IsRequired();
        }
    }
}
