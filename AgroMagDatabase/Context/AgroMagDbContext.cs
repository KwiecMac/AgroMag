using AgroMagDatabase.Models.Configurations;
using AgroMagDatabase.Models.Field;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMagDatabase.Context
{
    public class AgroMagDbContext : DbContext
    {
        public DbSet<Field> Fields { get; set; }

        public DbSet<FieldAddress> FieldAddresses { get; set; }

        public DbSet<FieldOperation> FieldOperations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FieldConfiguration());
            modelBuilder.ApplyConfiguration(new FieldAddressConfiguration());
            modelBuilder.ApplyConfiguration(new FieldOperationConfiguration());
        }
    }
}
