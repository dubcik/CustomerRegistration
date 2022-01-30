﻿// <auto-generated />
using CustomerRegFlorin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerRegFlorin.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20220128183943_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CustomerRegFlorin.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("addressCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("addressCity2")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("addressCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("addressCountry2")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("addressNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("addressNumber2")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("addressPostcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("addressPostcode2")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("addressStreet")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("addressStreet2")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("customerEmail")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("customerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("customerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("customerWebsite")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("customerId");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
