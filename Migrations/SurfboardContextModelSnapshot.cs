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

                    b.Property<int>("SurfboardId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SurfboardId");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pink",
                            SurfboardId = 3
                        },
                        new
                        {
                            Id = 2,
                            Name = "Grey",
                            SurfboardId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Black",
                            SurfboardId = 2
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
                });

            modelBuilder.Entity("firstTry.Models.OrderRow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurfBoardId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("SurfBoardId");

                    b.ToTable("OrderRows");
                });

            modelBuilder.Entity("firstTry.Models.Surfboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Shape")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Surfboards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Shape = "Gun"
                        },
                        new
                        {
                            Id = 2,
                            Shape = "Fish"
                        },
                        new
                        {
                            Id = 3,
                            Shape = "Shortboard"
                        },
                        new
                        {
                            Id = 4,
                            Shape = "Longboard"
                        });
                });

            modelBuilder.Entity("firstTry.Models.Color", b =>
                {
                    b.HasOne("firstTry.Models.Surfboard", "Surfboard")
                        .WithMany("Colors")
                        .HasForeignKey("SurfboardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
