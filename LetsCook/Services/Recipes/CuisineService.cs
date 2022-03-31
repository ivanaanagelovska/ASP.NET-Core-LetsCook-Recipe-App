namespace LetsCook.Services.Recipes
{
    using System.Collections.Generic;

    using LetsCook.Data;
    using LetsCook.Services.Recipes.Models;

    public class CuisineService : ICuisineService
    {
        private readonly LetsCookDbContext dbContext;

        public CuisineService(LetsCookDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<CuisineServiceModel> GetAllCuisines()
        {
            return this.dbContext
                    .Cuisines
                    .Select(c => new CuisineServiceModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                    })
                    .ToList();
        }
    }
}
