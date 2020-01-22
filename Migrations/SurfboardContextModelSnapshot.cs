﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using firstTry.Contexts;

namespace firstTry.Migrations
{
    [DbContext(typeof(SurfboardContext))]
    partial class SurfboardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("firstTry.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pink"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Grey"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Black"
                        });
                });

            modelBuilder.Entity("firstTry.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Bells Beach, Victoria",
                            FirstName = "Tyler",
                            LastName = "Wright"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Saquarema, Rio",
                            FirstName = "Silvana",
                            LastName = "Lima"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Honolua Bay, Maui",
                            FirstName = "Mason",
                            LastName = "Ho"
                        });
                });

            modelBuilder.Entity("firstTry.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 2,
                            OrderDate = new DateTime(2020, 1, 1, 13, 6, 58, 57, DateTimeKind.Local).AddTicks(8840)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 1,
                            OrderDate = new DateTime(2020, 1, 11, 13, 6, 58, 69, DateTimeKind.Local).AddTicks(970)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            OrderDate = new DateTime(2020, 1, 17, 13, 6, 58, 69, DateTimeKind.Local).AddTicks(1050)
                        });
                });

            modelBuilder.Entity("firstTry.Models.OrderRow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurfBoardId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("OrderId");

                    b.HasIndex("SurfBoardId");

                    b.ToTable("OrderRows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorId = 1,
                            OrderId = 1,
                            SurfBoardId = 2
                        },
                        new
                        {
                            Id = 2,
                            ColorId = 3,
                            OrderId = 1,
                            SurfBoardId = 2
                        },
                        new
                        {
                            Id = 3,
                            ColorId = 1,
                            OrderId = 1,
                            SurfBoardId = 3
                        },
                        new
                        {
                            Id = 4,
                            ColorId = 2,
                            OrderId = 2,
                            SurfBoardId = 1
                        },
                        new
                        {
                            Id = 5,
                            ColorId = 3,
                            OrderId = 3,
                            SurfBoardId = 3
                        });
                });

            modelBuilder.Entity("firstTry.Models.Surfboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Shape")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Surfboards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 2345,
                            Shape = "Gun"
                        },
                        new
                        {
                            Id = 2,
                            Price = 4325,
                            Shape = "Fish"
                        },
                        new
                        {
                            Id = 3,
                            Price = 2222,
                            Shape = "Shortboard"
                        },
                        new
                        {
                            Id = 4,
                            Price = 11403,
                            Shape = "Longboard"
                        });
                });

            modelBuilder.Entity("firstTry.Models.Order", b =>
                {
                    b.HasOne("firstTry.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("firstTry.Models.OrderRow", b =>
                {
                    b.HasOne("firstTry.Models.Color", "Color")
                        .WithMany("OrderRows")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("firstTry.Models.Order", "Order")
                        .WithMany("OrderRows")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("firstTry.Models.Surfboard", "Surfboard")
                        .WithMany("OrderRows")
                        .HasForeignKey("SurfBoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
