namespace LetsCook.Services.Recipes
{
    using System.Collections.Generic;

    using LetsCook.Data;
    using LetsCook.Services.Recipes.Models;

    public class CategoryService : ICategoryService
    {
        private readonly LetsCookDbContext dbContext;

        public CategoryService(LetsCookDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<CategoryServiceModel> GetAllCategories()
        {
            return this.dbContext
                    .Categories
                    .Select(c => new CategoryServiceModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                    })
                    .OrderBy(c=> c.Name)
                    .ToList();
        }
    }
}
