namespace LetsCook.Services.Recipes
{
    using LetsCook.Services.Recipes.Models;

    public interface IDifficultyService
    {
        IEnumerable<DifficultyServiceModel> GetAllDifficulties();
    }
}
