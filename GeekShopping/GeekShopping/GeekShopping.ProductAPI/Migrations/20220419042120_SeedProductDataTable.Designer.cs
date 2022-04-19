﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20220419042120_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.2.22153.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-shirt2",
                            Description = "Description2",
                            ImageUrl = "",
                            Name = "Name2",
                            Price = 50m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "T-shirt3",
                            Description = "Description3",
                            ImageUrl = "",
                            Name = "Name3",
                            Price = 60m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "T-shirt4",
                            Description = "Description4",
                            ImageUrl = "",
                            Name = "Name4",
                            Price = 70m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "T-shirt5",
                            Description = "Description5",
                            ImageUrl = "",
                            Name = "Name5",
                            Price = 80m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "T-shirt6",
                            Description = "Description6",
                            ImageUrl = "",
                            Name = "Name6",
                            Price = 90m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "T-shirt",
                            Description = "Description",
                            ImageUrl = "",
                            Name = "Name",
                            Price = 50m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}