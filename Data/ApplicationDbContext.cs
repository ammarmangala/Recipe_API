using Microsoft.EntityFrameworkCore;

namespace Template_Web_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }

    

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    // Fluent API configuratie (zoals hierboven vermeld)

    //    // Seeding voor Category
    //    modelBuilder.Entity<Category>().HasData(
    //        new Category { Id = 1, Name = "Voetbal" },
    //        new Category { Id = 2, Name = "Tennis" },
    //        new Category { Id = 3, Name = "Wielrennen" },
    //        new Category { Id = 4, Name = "Basketbal" }
    //    // Voeg eventueel nog meer categorieën toe
    //    );

    //    // Voeg hier eventueel seeding voor Product toe
    //}

    //public DbSet<Recipe> Recipes { get; set; }
    //public DbSet<Ingredient> Ingredients { get; set; }
    //public DbSet<Category> Categories { get; set; }
}
