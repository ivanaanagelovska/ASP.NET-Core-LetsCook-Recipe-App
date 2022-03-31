namespace LetsCook.Services.Recipes
{
    using System.Collections.Generic;

    using LetsCook.Data;
    using LetsCook.Services.Recipes.Models;

    public class DifficultyService : IDifficultyService
    {
        private readonly LetsCookDbContext dbContext;

        public DifficultyService(LetsCookDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<DifficultyServiceModel> GetAllDifficulties()
        {
            return this.dbContext
                    .Difficulties
                    .Select(x => new DifficultyServiceModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                    })
                    .ToList();
        }
    }
}
