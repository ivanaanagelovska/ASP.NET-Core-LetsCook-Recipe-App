namespace LetsCook.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using LetsCook.Data.Models.RecipeModel;

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

        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Recipe>(entity =>
            {
                entity
                    .HasOne(r => r.Category)
                    .WithMany(r => r.Recipes)
                    .HasForeignKey(r => r.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity
                    .HasOne(r => r.Cuisine)
                    .WithMany(r => r.Recipes)
                    .HasForeignKey(r => r.CuisineId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity
                    .HasOne(r => r.Difficulty)
                    .WithMany(r => r.Recipes)
                    .HasForeignKey(r => r.DifficultyId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<RecipeIngredient>(entity =>
            {
                entity.HasOne(i => i.Ingredient)
                    .WithMany(i => i.Recipes)
                    .HasForeignKey(i => i.IngredientId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(r => r.Recipe)
                   .WithMany(r => r.Ingredients)
                   .HasForeignKey(i => i.RecipeId)
                   .OnDelete(DeleteBehavior.Restrict);

                entity
                    .Property(p => p.Amount)
                    .HasColumnType("decimal(4, 2)");
            });

            builder.Entity<RecipeTag>(entity =>
            {
                entity.HasOne(t => t.Tag)
                    .WithMany(t => t.Recipes)
                    .HasForeignKey(t => t.TagId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(r => r.Recipe)
                   .WithMany(r => r.Tags)
                   .HasForeignKey(i => i.RecipeId)
                   .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Instruction>()
                .HasOne(i => i.Recipe)
                .WithMany(i => i.Instructions)
                .HasForeignKey(i => i.RecipeId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
