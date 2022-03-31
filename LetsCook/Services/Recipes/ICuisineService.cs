namespace LetsCook.Services.Recipes
{
    using LetsCook.Services.Recipes.Models;

    public interface ICuisineService
    {
        IEnumerable<CuisineServiceModel> GetAllCuisines();
    }
}
