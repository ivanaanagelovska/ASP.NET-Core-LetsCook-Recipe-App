namespace LetsCook.Services.Recipes
{
    using LetsCook.Services.Recipes.Models;

    public interface ICategoryService
    {
        IEnumerable<CategoryServiceModel> GetAllCategories();
    }
}
