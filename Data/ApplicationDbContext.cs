﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Recipe_API.Entities;

namespace Recipe_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Soepen" },
                new Category { Id = 2, Name = "Vegetarisch" },
                new Category { Id = 3, Name = "Voorgerecht" },
                new Category { Id = 4, Name = "Hoofdgerecht" },
                new Category { Id = 5, Name = "Dessert" }
            );
            base.OnModelCreating(modelBuilder);
        }

    }
}
