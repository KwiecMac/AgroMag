﻿// <auto-generated />
using System;
using AgroMagDatabase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgroMagDatabase.Migrations
{
    [DbContext(typeof(AgroMagDbContext))]
    partial class AgroMagDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgroMagDatabase.Models.Field.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FieldAddressId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOwn")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("FieldAddressId")
                        .IsUnique();

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("AgroMagDatabase.Models.Field.FieldAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("FieldAddresses");
                });

            modelBuilder.Entity("AgroMagDatabase.Models.Field.FieldOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contractor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("FieldOperations");
                });

            modelBuilder.Entity("AgroMagDatabase.Models.Field.Field", b =>
                {
                    b.HasOne("AgroMagDatabase.Models.Field.FieldAddress", "FieldAddress")
                        .WithOne("Field")
                        .HasForeignKey("AgroMagDatabase.Models.Field.Field", "FieldAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FieldAddress");
                });

            modelBuilder.Entity("AgroMagDatabase.Models.Field.FieldOperation", b =>
                {
                    b.HasOne("AgroMagDatabase.Models.Field.Field", "Field")
                        .WithMany("FieldOperation")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("AgroMagDatabase.Models.Field.Field", b =>
                {
                    b.Navigation("FieldOperation");
                });

            modelBuilder.Entity("AgroMagDatabase.Models.Field.FieldAddress", b =>
                {
                    b.Navigation("Field");
                });
#pragma warning restore 612, 618
        }
    }
}
