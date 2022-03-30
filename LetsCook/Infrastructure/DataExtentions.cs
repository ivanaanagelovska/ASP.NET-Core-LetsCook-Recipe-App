namespace LetsCook.Infrastructure
{
    using LetsCook.Data;
    using LetsCook.Data.Models.RecipeModel;
    
    using Microsoft.EntityFrameworkCore;


    public static class DataExtensions
    {
        public static WebApplication ApplyMigrations(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<LetsCookDbContext>();
            dbContext.Database.Migrate();

            SeedCategories(dbContext);
            SeedCuisines(dbContext);
            SeedDifficulties(dbContext);
            SeedRecipeTags(dbContext);

            return app;
        }

        private static void SeedCategories(LetsCookDbContext dbContext)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            dbContext.Categories.AddRange(new[]
            {
                        new Category{ Name = "Appetizers"},
                        new Category{ Name = "Breakfast & Brunch"},
                        new Category{ Name = "Cocktails"},
                        new Category{ Name = "Desserts"},
                        new Category{ Name = "Juices"},
                        new Category{ Name = "Mains"},
                        new Category{ Name = "Salads"},
                        new Category{ Name = "Salad Dressing"},
                        new Category{ Name = "Sauces"},
                        new Category{ Name = "Sides"},
                        new Category{ Name = "Snacks"},
                    });

            dbContext.SaveChanges();
        }

        private static void SeedDifficulties(LetsCookDbContext dbContext)
        {
            if (dbContext.Difficulties.Any())
            {
                return;
            }

            dbContext.Difficulties.AddRange(new[]
            {
                        new Difficulty{ Name = "Super Easy"},
                        new Difficulty{ Name = "Not too tricky"},
                        new Difficulty{ Name = "Showing off"},
                    });

            dbContext.SaveChanges();
        }

        private static void SeedRecipeTags(LetsCookDbContext dbContext)
        {
            if (dbContext.Tags.Any())
            {
                return;
            }

            dbContext.Tags.AddRange(new[]
            {
                        new Tag{ Name = "Vegetarian"},
                        new Tag{ Name = "Gluten Free"},
                        new Tag{ Name = "Vegan"},
                        new Tag{ Name = "Dairy Free"},
                        new Tag{ Name = "Healthy Food"},
                        new Tag{ Name = "BBQ"},
                        new Tag{ Name = "Beef"},
                        new Tag{ Name = "Chicken"},
                        new Tag{ Name = "Turkey"},
                        new Tag{ Name = "Pork"},
                        new Tag{ Name = "Lamb"},
                        new Tag{ Name = "Duck"},
                        new Tag{ Name = "Seafood"},
                        new Tag{ Name = "Fish"},
                        new Tag{ Name = "Pasta"},
                        new Tag{ Name = "Rice"},
                        new Tag{ Name = "Potato"},
                        new Tag{ Name = "Tofu"},
                        new Tag{ Name = "Cheese"},
                        new Tag{ Name = "Eggs"},
                        new Tag{ Name = "Vegetables"},
                        new Tag{ Name = "Fruit"},
                        new Tag{ Name = "Pie"},
                        new Tag{ Name = "Pancake"},
                        new Tag{ Name = "Cookie"},
                        new Tag{ Name = "Cake"},
                        new Tag{ Name = "Biscuit"},
                        new Tag{ Name = "Muffin"},
                        new Tag{ Name = "Brownies"},
                        new Tag{ Name = "Bread"},
                        new Tag{ Name = "Chocolate"},
                        new Tag{ Name = "Easter"},
                        new Tag{ Name = "Christmas"},
                        new Tag{ Name = "Valentine's Day"},
                        new Tag{ Name="Party Food"}
                    });

            dbContext.SaveChanges();
        }

        private static void SeedCuisines(LetsCookDbContext dbContext)
        {
            if (dbContext.Cuisines.Any())
            {
                return;
            }

            dbContext.Cuisines.AddRange(new[]
            {
                        new Cuisine{ Name="African"},
                        new Cuisine{ Name="Asian"},
                        new Cuisine{ Name="Caribbean"},
                        new Cuisine{ Name="Central American"},
                        new Cuisine{ Name="Middle Eastern"},
                        new Cuisine{ Name="South American"},
                        new Cuisine{ Name="Asian"},
                        new Cuisine{ Name="Europe"},

                    });
        }
    }
}
