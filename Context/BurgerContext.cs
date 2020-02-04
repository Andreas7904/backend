using System;
using BackendProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Contexts
{
    public class BurgerContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //<—— Tabell Product
        public DbSet<BongDetails> BongsDetails { get; set; } //<—— Tabell BongDetails
        public DbSet<Ingredient> Ingredients { get; set; } //<—— Tabell Ingredient

        public DbSet<Bong> Bongs { get; set; } //<—— Tabell Bongs

        protected override void OnConfiguring(DbContextOptionsBuilder options)

        => options.UseSqlite("Data Source=Burger.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Burger = "Burger",
                Price = 4,
            });

            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                Id = 1,
                IngredientName = "Salad",
                Price = 1
            },
            new Ingredient
            {
                Id = 2,
                IngredientName = "Cheese",
                Price = 2
            },
            new Ingredient
            {
                Id = 3,
                IngredientName = "Bacon",
                Price = 3
            },
            new Ingredient
            {
                Id = 4,
                IngredientName = "Meat",
                Price = 10
            });
            modelBuilder.Entity<BongDetails>().HasData(new BongDetails
            {
                Id = 1,
                ProductId = 1,
                IngredientId = 1

            });
            modelBuilder.Entity<Bong>().HasData(new Bong
            {
                Id = 1,
                Created = DateTime.Now
            });
        }
    }
}