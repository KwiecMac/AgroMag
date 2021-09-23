﻿using AgroMagDatabase.Models.Configurations;
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
        private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=AgroMagDb;Trusted_Connection=True;";

        public DbSet<Field> Fields { get; set; }

        public DbSet<FieldAddress> FieldAddresses { get; set; }

        public DbSet<FieldOperation> FieldOperations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FieldConfiguration());
            modelBuilder.ApplyConfiguration(new FieldAddressConfiguration());
            modelBuilder.ApplyConfiguration(new FieldOperationConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}
