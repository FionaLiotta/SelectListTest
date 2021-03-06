﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelectListTest.Data;

namespace SelectListTest.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20190521195809_ReInit")]
    partial class ReInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SelectListTest.Models.CoffeeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId");

                    b.Property<string>("TasteNotes");

                    b.Property<int?>("VarietyId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("VarietyId");

                    b.ToTable("Coffees");
                });

            modelBuilder.Entity("SelectListTest.Models.CountryModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("SelectListTest.Models.InventoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CoffeeId");

                    b.Property<decimal>("LbsOnHand")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PricePerLbs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("CoffeeId");

                    b.HasIndex("VendorId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("SelectListTest.Models.RoastModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roasts");
                });

            modelBuilder.Entity("SelectListTest.Models.VarietyModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Varieties");
                });

            modelBuilder.Entity("SelectListTest.Models.VendorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("SelectListTest.Models.CoffeeModel", b =>
                {
                    b.HasOne("SelectListTest.Models.CountryModel", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("SelectListTest.Models.VarietyModel", "Variety")
                        .WithMany()
                        .HasForeignKey("VarietyId");
                });

            modelBuilder.Entity("SelectListTest.Models.InventoryModel", b =>
                {
                    b.HasOne("SelectListTest.Models.CoffeeModel", "Coffee")
                        .WithMany()
                        .HasForeignKey("CoffeeId");

                    b.HasOne("SelectListTest.Models.VendorModel", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");
                });
#pragma warning restore 612, 618
        }
    }
}
