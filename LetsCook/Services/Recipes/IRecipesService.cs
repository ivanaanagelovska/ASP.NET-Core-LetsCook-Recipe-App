namespace LetsCook.Services.Recipes
{
    using LetsCook.Models.Recipes;
    public interface IRecipesService
    {
        void Create(CreateRecipeFormModel recipeFormModel);
    }
}
