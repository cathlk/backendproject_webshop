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

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 2,
                            OrderDate = new DateTime(2020, 1, 16, 13, 49, 27, 261, DateTimeKind.Local).AddTicks(6250),
                            Price = 0
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 1,
                            OrderDate = new DateTime(2020, 1, 26, 13, 49, 27, 273, DateTimeKind.Local).AddTicks(6880),
                            Price = 0
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            OrderDate = new DateTime(2020, 2, 1, 13, 49, 27, 273, DateTimeKind.Local).AddTicks(6970),
                            Price = 0
                        });
                });

            modelBuilder.Entity("firstTry.Models.OrderRow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SizeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurfBoardId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("SizeId");

                    b.HasIndex("SurfBoardId");

                    b.ToTable("OrderRows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 0,
                            OrderId = 1,
                            Price = 0,
                            SizeId = 1,
                            SurfBoardId = 2
                        },
                        new
                        {
                            Id = 2,
                            Amount = 0,
                            OrderId = 1,
                            Price = 0,
                            SizeId = 2,
                            SurfBoardId = 2
                        },
                        new
                        {
                            Id = 3,
                            Amount = 0,
                            OrderId = 1,
                            Price = 0,
                            SizeId = 3,
                            SurfBoardId = 3
                        },
                        new
                        {
                            Id = 4,
                            Amount = 0,
                            OrderId = 2,
                            Price = 0,
                            SizeId = 5,
                            SurfBoardId = 1
                        },
                        new
                        {
                            Id = 5,
                            Amount = 0,
                            OrderId = 3,
                            Price = 0,
                            SizeId = 4,
                            SurfBoardId = 3
                        });
                });

            modelBuilder.Entity("firstTry.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "5'6"
                        },
                        new
                        {
                            Id = 2,
                            Name = "6'0"
                        },
                        new
                        {
                            Id = 3,
                            Name = "7'0"
                        },
                        new
                        {
                            Id = 4,
                            Name = "7'6"
                        },
                        new
                        {
                            Id = 5,
                            Name = "9'1"
                        },
                        new
                        {
                            Id = 6,
                            Name = "9'6"
                        });
                });

            modelBuilder.Entity("firstTry.Models.Surfboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

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
                            Description = "Denna brädan handlar om glid och flow med möjlighet för surfaren att vandra på brädan för maximal “nose riding time”. Av denna anledning är denna brädan lång, bredd och otroligt stabil. Om du är på jakt efter en riktigt rolig longboard att surfa down the line med så är Retro ditt val.",
                            ImageUrl = "https://shopcdn2.textalk.se/shop/26254/art54/h8795/22218795-origpic-567940.jpg?max-width=549&max-height=549&quality=85",
                            Price = 11403,
                            Shape = "Longboard"
                        },
                        new
                        {
                            Id = 2,
                            Description = "En shortboard med longboard outline i framdelen! Fånga vågor är enkelt med denna bräda och den flatta rockern ger dig bästa glid. Bottenkurvan med pintail (samt subtil rocker vid tailen) ser till att du behåller full kontroll och manövrerbarhet. Inte nog med detta, Lovechild erbjuder dessutom 3 olika fin set up möjligheter. Single-fin, 2+1 eller quad!",
                            ImageUrl = "https://shopcdn2.textalk.se/shop/26254/art54/h7693/38987693-origpic-98a47a.jpg?max-width=549&max-height=549&quality=85",
                            Price = 2222,
                            Shape = "Hybrid"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Modern har blandat inslag av retrofish-shape från 70-talet tillsammans med en modern bottenstruktur samt med en quad-setup för att göra denna bräda till det optimala valet i små till medelstora vågor. Flow, smoothness och pure fun kännertecknar denna bräda.",
                            ImageUrl = "https://shopcdn2.textalk.se/shop/26254/art54/h4090/156144090-origpic-f52a2b.jpg?max-width=549&max-height=549&quality=85",
                            Price = 4325,
                            Shape = "Fish"
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
                    b.HasOne("firstTry.Models.Order", "Order")
                        .WithMany("OrderRows")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("firstTry.Models.Size", "Size")
                        .WithMany("OrderRows")
                        .HasForeignKey("SizeId")
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
