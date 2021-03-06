﻿// <auto-generated />
using System;
using BackendProject.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackendProject.Migrations
{
    [DbContext(typeof(BurgerContext))]
    [Migration("20200121130903_CORS")]
    partial class CORS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("BackendProject.Models.Bong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BongDetailsId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BongDetailsId");

                    b.ToTable("Bongs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2020, 1, 21, 14, 9, 2, 901, DateTimeKind.Local).AddTicks(8250)
                        });
                });

            modelBuilder.Entity("BackendProject.Models.BongDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IngredientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("ProductId");

                    b.ToTable("BongsDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IngredientId = 1,
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IngredientName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IngredientName = "Salad",
                            Price = 1
                        },
                        new
                        {
                            Id = 2,
                            IngredientName = "Cheese",
                            Price = 2
                        },
                        new
                        {
                            Id = 3,
                            IngredientName = "Bacon",
                            Price = 3
                        },
                        new
                        {
                            Id = 4,
                            IngredientName = "Meat",
                            Price = 10
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Burger")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Burger = "Burger",
                            Price = 4
                        });
                });

            modelBuilder.Entity("BackendProject.Models.Bong", b =>
                {
                    b.HasOne("BackendProject.Models.BongDetails", "BongDetails")
                        .WithMany()
                        .HasForeignKey("BongDetailsId");
                });

            modelBuilder.Entity("BackendProject.Models.BongDetails", b =>
                {
                    b.HasOne("BackendProject.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendProject.Models.Product", "Product")
                        .WithMany("bongsDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
