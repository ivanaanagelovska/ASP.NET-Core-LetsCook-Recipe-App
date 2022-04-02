namespace LetsCook.Services.Recipes
{
    using LetsCook.Data;
    using LetsCook.Data.Models.RecipeModel;
    using LetsCook.Models.Recipes;

    public class RecipesService : IRecipesService
    {
        private readonly LetsCookDbContext dbContext;

        public RecipesService(LetsCookDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(CreateRecipeFormModel recipeFormModel)
        {
            var recipe = new Recipe
            {
                Name = recipeFormModel.Name,
                Description = recipeFormModel.Description,
                PreparationTime = TimeSpan.FromMinutes(recipeFormModel.PreparationTime),
                CookingTime = TimeSpan.FromMinutes(recipeFormModel.CookingTime),
                RestTime = TimeSpan.FromMinutes(recipeFormModel.RestTime),
                Servings = recipeFormModel.Servings,
                CategoryId = recipeFormModel.CategoryId,
                CuisineId = recipeFormModel.CuisineId,
                DifficultyId = recipeFormModel.DifficultyId,
                CreatedOn = DateTime.UtcNow,
            };
            foreach (var item in recipeFormModel.Tags)
            {
                var tag = this.dbContext.Tags.FirstOrDefault(t => t.Name == item.TagName);
                if (tag == null)
                {
                    tag = new Tag
                    {
                        Name = item.TagName,
                        CreatedOn = DateTime.UtcNow,
                    };
                }

                recipe.Tags.Add(new RecipeTag
                {
                    Tag = tag,
                });
            }

            foreach (var item in recipeFormModel.Images)
            {
                var image = this.dbContext.Images.FirstOrDefault(i => i.ImageUrl == item.ImageUrl);
                if (image == null)
                {
                    image = new Image
                    {
                        ImageUrl = item.ImageUrl,
                        CreatedOn = DateTime.UtcNow,
                    };
                }

                recipe.Images.Add(image);
            }

            foreach (var item in recipeFormModel.Notes)
            {
                var note = this.dbContext.Notes.FirstOrDefault(n => n.Text == item.Text);
                if (note == null)
                {
                    note = new Note
                    {
                        Text = item.Text,
                        CreatedOn = DateTime.UtcNow,
                    };
                }
                recipe.Notes.Add(note);
            }

            this.dbContext.Add(recipe);
            this.dbContext.SaveChanges();
        }
    }
}
