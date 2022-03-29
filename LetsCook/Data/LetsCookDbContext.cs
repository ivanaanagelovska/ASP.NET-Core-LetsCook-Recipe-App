namespace LetsCook.Data
{
    using LetsCook.Data.Models.RecipeModel;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class LetsCookDbContext : IdentityDbContext
    {
        public LetsCookDbContext(DbContextOptions<LetsCookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; init; }

        public DbSet<Cuisine> Cuisines { get; init; }

        public DbSet<Ingredient> Ingredients { get; init; }

        public DbSet<Instruction> Instructions { get; init; }

        public DbSet<Recipe> Recipes { get; init; }

        public DbSet<RecipeIngredient> RecipeIngredients { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RecipeIngredient>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(4, 2)");
        }
    }
}
