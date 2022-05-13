﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PathOrderManagement.DataAccess;

#nullable disable

namespace PathOrderManagement.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CargoCompanies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"),
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 152, DateTimeKind.Local).AddTicks(9467),
                            IsDeleted = false,
                            Name = "Yurtiçi Kargo"
                        },
                        new
                        {
                            Id = new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"),
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 152, DateTimeKind.Local).AddTicks(9772),
                            IsDeleted = false,
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

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CompanyID");

                    b.ToTable("CategoryCargo");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd42084f-e3fd-490c-ac64-d7636f24e513"),
                            CategoryID = new Guid("b3817af4-5107-4c39-99f9-37595c7bda31"),
                            CompanyID = new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"),
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 153, DateTimeKind.Local).AddTicks(2228),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("28f159ff-fc7a-4af2-80ef-56b19fa211f5"),
                            CategoryID = new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"),
                            CompanyID = new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"),
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 153, DateTimeKind.Local).AddTicks(2895),
                            IsDeleted = false
                        });
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
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 152, DateTimeKind.Local).AddTicks(7216),
                            IsDeleted = false,
                            Name = "Giyim"
                        },
                        new
                        {
                            Id = new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"),
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 152, DateTimeKind.Local).AddTicks(7602),
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
                            Id = new Guid("c941de0c-7068-481f-88a5-0d2d33bad26c"),
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 150, DateTimeKind.Local).AddTicks(2026),
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
                            Id = new Guid("62be0e98-ffaa-484e-8a03-523035b108e1"),
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 151, DateTimeKind.Local).AddTicks(4443),
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
                            Id = new Guid("85c32bf1-48ae-45da-b754-0fe20ae96c27"),
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 151, DateTimeKind.Local).AddTicks(4475),
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
                            Id = new Guid("d0241beb-0db3-4839-a405-41f406788d82"),
                            CreatedOn = new DateTime(2022, 5, 13, 5, 7, 47, 151, DateTimeKind.Local).AddTicks(4477),
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