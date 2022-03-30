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

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cuisine> Cuisines { get; set; }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Instruction> Instructions { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        public DbSet<RecipeTag> RecipeTags { get; set; }

        public DbSet<SubRecipe> SubRecipes { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RecipeIngredient>(entity =>
           {
               entity.Property(p => p.Amount)
               .HasColumnType("decimal(4, 2)");

           });

            builder.Entity<Recipe>(entity =>
            {
                entity.HasOne(r => r.Category)
                    .WithMany(r => r.Recipes)
                    .HasForeignKey(r => r.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(r => r.Cuisine)
                    .WithMany(r => r.Recipes)
                    .HasForeignKey(r => r.CuisineId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(r => r.Difficulty)
                    .WithMany(r => r.Recipes)
                    .HasForeignKey(r => r.DifficultyId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(r => r.Images)
                    .WithOne(r => r.Recipe)
                    .HasForeignKey(r => r.RecipeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(r => r.Notes)
                    .WithOne(r => r.Recipe)
                    .HasForeignKey(r => r.RecipeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(r => r.Ingredients)
                    .WithOne(r => r.Recipe)
                    .HasForeignKey(r => r.RecipeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(r => r.Tags)
                    .WithOne(r => r.Recipe)
                    .HasForeignKey(r => r.RecipeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(r => r.SubRecipes)
                    .WithOne(r => r.Recipe)
                    .HasForeignKey(r => r.RecipeId)
                    .OnDelete(DeleteBehavior.Restrict);

            });
        }
    }
}
