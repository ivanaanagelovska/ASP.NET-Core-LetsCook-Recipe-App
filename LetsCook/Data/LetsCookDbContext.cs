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

            builder
                .Entity<RecipeIngredient>()
                .HasKey(k => new
                {
                    k.RecipeId,
                    k.IngredientId
                });

            builder
                .Entity<Recipe>(entity =>
                {
                    entity.HasOne(e => e.Category)
                        .WithMany(e => e.Recipes)
                        .HasForeignKey(e => e.CategoryId)
                        .OnDelete(DeleteBehavior.Restrict);

                    entity.HasOne(e => e.Cuisine)
                        .WithMany(e => e.Recipes)
                        .HasForeignKey(e => e.CuisineId)
                        .OnDelete(DeleteBehavior.Restrict);

                    entity.HasMany(e => e.Instructions)
                        .WithOne(e => e.Recipe)
                        .HasForeignKey(e => e.RecipeId)
                        .OnDelete(DeleteBehavior.Restrict);
                });
        }
    }
}
