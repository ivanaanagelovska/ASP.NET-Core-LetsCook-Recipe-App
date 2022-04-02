namespace LetsCook.Infrastructure
{
    using LetsCook.Data;
    using LetsCook.Data.Models.RecipeModel;

    using Microsoft.EntityFrameworkCore;


    public static class DataExtensions
    {
        public static WebApplication DbInitializer
            (this WebApplication app)
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
                        new Category{ Name = "Appetizers", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Breakfast & Brunch", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Cocktails", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Desserts", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Juices", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Mains", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Salads", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Salad Dressing", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Sauces", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Sides", CreatedOn = DateTime.UtcNow},
                        new Category{ Name = "Snacks", CreatedOn = DateTime.UtcNow},
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
                        new Difficulty{ Name = "Super Easy", CreatedOn = DateTime.UtcNow},
                        new Difficulty{ Name = "Not Too Tricky", CreatedOn = DateTime.UtcNow},
                        new Difficulty{ Name = "Showing Off", CreatedOn = DateTime.UtcNow},
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
                        new Tag{ Name = "Vegetarian", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Gluten Free", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Vegan", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Dairy Free", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Healthy Food", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "BBQ", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Beef", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Chicken", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Turkey", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Pork", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Lamb", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Duck", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Seafood", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Fish", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Pasta", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Rice", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Potato", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Tofu", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Cheese", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Eggs", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Vegetables", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Fruit", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Pie", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Pancake", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Cookie", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Cake", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Biscuit", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Muffin", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Brownies", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Bread", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Chocolate", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Easter", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Christmas", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name = "Valentine's Day", CreatedOn = DateTime.UtcNow},
                        new Tag{ Name="Party Food", CreatedOn = DateTime.UtcNow}
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
                        new Cuisine{ Name="African", CreatedOn = DateTime.UtcNow },
                        new Cuisine{ Name="Asian", CreatedOn = DateTime.UtcNow},
                        new Cuisine{ Name="Caribbean", CreatedOn = DateTime.UtcNow},
                        new Cuisine{ Name="Central American", CreatedOn = DateTime.UtcNow},
                        new Cuisine{ Name="Middle Eastern", CreatedOn = DateTime.UtcNow},
                        new Cuisine{ Name="South American", CreatedOn = DateTime.UtcNow},
                        new Cuisine{ Name="Asian", CreatedOn = DateTime.UtcNow},
                        new Cuisine{ Name="Europe", CreatedOn = DateTime.UtcNow},

            });
        }
    }
}
