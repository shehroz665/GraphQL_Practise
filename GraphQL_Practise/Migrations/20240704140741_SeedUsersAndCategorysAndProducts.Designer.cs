﻿// <auto-generated />
using System;
using GraphQL_Practise.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQLPractise.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240704140741_SeedUsersAndCategorysAndProducts")]
    partial class SeedUsersAndCategorysAndProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GraphQL_Practise.Models.Categorys", b =>
                {
                    b.Property<int>("CategoryKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryKey"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryKey");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryKey = 1,
                            CategoryName = "Bags",
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9137),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9137)
                        },
                        new
                        {
                            CategoryKey = 2,
                            CategoryName = "Shoes",
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9140),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9141)
                        },
                        new
                        {
                            CategoryKey = 3,
                            CategoryName = "Clothing",
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9142),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9143)
                        },
                        new
                        {
                            CategoryKey = 4,
                            CategoryName = "Accessories",
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9144),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9145)
                        },
                        new
                        {
                            CategoryKey = 5,
                            CategoryName = "Electronics",
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9146),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9147)
                        });
                });

            modelBuilder.Entity("GraphQL_Practise.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("CategoryKey")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryKey = 1,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9171),
                            Name = "School Bag",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9172)
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryKey = 2,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9176),
                            Name = "Running Shoes",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9177)
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryKey = 3,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9179),
                            Name = "T-Shirt",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9179)
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryKey = 4,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9181),
                            Name = "Leather Belt",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9182)
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryKey = 5,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9183),
                            Name = "Smartphone",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9184)
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryKey = 1,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9186),
                            Name = "Laptop Bag",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9186)
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryKey = 2,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9188),
                            Name = "Sandals",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9188)
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryKey = 3,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9189),
                            Name = "Jacket",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9190)
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryKey = 4,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9191),
                            Name = "Watch",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9192)
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryKey = 5,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9194),
                            Name = "Tablet",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9195)
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryKey = 1,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9196),
                            Name = "Travel Bag",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9197)
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryKey = 2,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9198),
                            Name = "Formal Shoes",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9198)
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryKey = 3,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9200),
                            Name = "Jeans",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9200)
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryKey = 4,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9202),
                            Name = "Necklace",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9202)
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryKey = 5,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9204),
                            Name = "Headphones",
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9204)
                        });
                });

            modelBuilder.Entity("GraphQL_Practise.Models.Users", b =>
                {
                    b.Property<int>("UserKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserKey"));

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserKey");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserKey = 1,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9059),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9075),
                            UserEmail = "shehrozmalik665@gmail.com",
                            UserName = "Shehroz Ali"
                        },
                        new
                        {
                            UserKey = 2,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9084),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9085),
                            UserEmail = "ali@gmail.com",
                            UserName = "Ali"
                        },
                        new
                        {
                            UserKey = 3,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9086),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9087),
                            UserEmail = "jawad@gmail.com",
                            UserName = "Jawad"
                        },
                        new
                        {
                            UserKey = 4,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9088),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9089),
                            UserEmail = "wahab@gmail.com",
                            UserName = "Wahab"
                        },
                        new
                        {
                            UserKey = 5,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9090),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9090),
                            UserEmail = "waqas@gmail.com",
                            UserName = "Waqas"
                        },
                        new
                        {
                            UserKey = 6,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9093),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9094),
                            UserEmail = "hassan@gmail.com",
                            UserName = "Hassan"
                        },
                        new
                        {
                            UserKey = 7,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9095),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9096),
                            UserEmail = "usman@gmail.com",
                            UserName = "Usman"
                        },
                        new
                        {
                            UserKey = 8,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9097),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9097),
                            UserEmail = "ahmad@gmail.com",
                            UserName = "Ahmad"
                        },
                        new
                        {
                            UserKey = 9,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9099),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9099),
                            UserEmail = "bilal@gmail.com",
                            UserName = "Bilal"
                        },
                        new
                        {
                            UserKey = 10,
                            CreatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9101),
                            UpdatedOn = new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9101),
                            UserEmail = "noman@gmail.com",
                            UserName = "Noman"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
