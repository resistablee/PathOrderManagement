﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PathOrderManagement.DataAccess;

#nullable disable

namespace PathOrderManagement.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220513013353_seed-data")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Cargo.Cargo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TrackingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyID");

                    b.HasIndex("OrderID");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Cargo.CargoCompanies", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CargoCompanies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"),
                            CreatedOn = new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(3635),
                            Name = "Yurtiçi Kargo"
                        },
                        new
                        {
                            Id = new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"),
                            CreatedOn = new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(3946),
                            Name = "Aras Kargo"
                        });
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Cargo.CategoryCargo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CompanyID");

                    b.ToTable("CategoryCargo");
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Order.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Order.OrderCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderCategory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b3817af4-5107-4c39-99f9-37595c7bda31"),
                            CreatedOn = new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(1478),
                            IsDeleted = false,
                            Name = "Giyim"
                        },
                        new
                        {
                            Id = new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"),
                            CreatedOn = new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(1845),
                            IsDeleted = false,
                            Name = "Gıda"
                        });
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.User.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d417f97a-9613-44ba-a392-3df4af9a3302"),
                            CreatedOn = new DateTime(2022, 5, 13, 4, 33, 52, 240, DateTimeKind.Local).AddTicks(1944),
                            Email = "superadmin@path.com.tr",
                            Firstname = "SuperAdmin",
                            IsDeleted = false,
                            Lastname = "Path",
                            Password = "super123",
                            Phone = "0553 553 5353",
                            UserType = 1
                        },
                        new
                        {
                            Id = new Guid("b08851a1-7117-46bd-8736-4e271fd80bda"),
                            CreatedOn = new DateTime(2022, 5, 13, 4, 33, 52, 241, DateTimeKind.Local).AddTicks(2123),
                            Email = "systemadmin@path.com.tr",
                            Firstname = "SystemAdmin",
                            IsDeleted = false,
                            Lastname = "Path",
                            Password = "system123",
                            Phone = "0507 520 4582",
                            UserType = 2
                        },
                        new
                        {
                            Id = new Guid("b792f048-94f4-4e34-850f-5dfe092ae196"),
                            CreatedOn = new DateTime(2022, 5, 13, 4, 33, 52, 241, DateTimeKind.Local).AddTicks(2140),
                            Email = "admin@path.com.tr",
                            Firstname = "Admin",
                            IsDeleted = false,
                            Lastname = "Path",
                            Password = "admin123",
                            Phone = "0542 652 2358",
                            UserType = 3
                        },
                        new
                        {
                            Id = new Guid("c4851dd8-c1b4-45a4-a3ef-2c6e97fe924b"),
                            CreatedOn = new DateTime(2022, 5, 13, 4, 33, 52, 241, DateTimeKind.Local).AddTicks(2142),
                            Email = "resistablee7@hotmail.com",
                            Firstname = "Selman",
                            IsDeleted = false,
                            Lastname = "KOYAN",
                            Password = "123",
                            Phone = "0553 421 0543",
                            UserType = 4
                        });
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Cargo.Cargo", b =>
                {
                    b.HasOne("PathOrderManagement.Entity.DbPathOrderManagement.Cargo.CargoCompanies", "Company")
                        .WithMany("Cargos")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PathOrderManagement.Entity.DbPathOrderManagement.Order.Order", "Order")
                        .WithMany("Cargo")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Cargo.CategoryCargo", b =>
                {
                    b.HasOne("PathOrderManagement.Entity.DbPathOrderManagement.Order.OrderCategory", "Category")
                        .WithMany("CategoryCargos")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PathOrderManagement.Entity.DbPathOrderManagement.Cargo.CargoCompanies", "Company")
                        .WithMany("CategoryCargos")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Order.Order", b =>
                {
                    b.HasOne("PathOrderManagement.Entity.DbPathOrderManagement.Order.OrderCategory", "Category")
                        .WithMany("Orders")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PathOrderManagement.Entity.DbPathOrderManagement.User.User", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Cargo.CargoCompanies", b =>
                {
                    b.Navigation("Cargos");

                    b.Navigation("CategoryCargos");
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Order.Order", b =>
                {
                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.Order.OrderCategory", b =>
                {
                    b.Navigation("CategoryCargos");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PathOrderManagement.Entity.DbPathOrderManagement.User.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
