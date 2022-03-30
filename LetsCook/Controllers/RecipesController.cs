namespace LetsCook.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using LetsCook.Models.Recipes;
    using LetsCook.Data;
    using LetsCook.Data.Models.RecipeModel;

    public class RecipesController : Controller
    {
        private readonly LetsCookDbContext dbContext;

        public RecipesController(LetsCookDbContext db)
        {
            this.dbContext = db;
        }
        public IActionResult Create()
        {
            var recipe = new CreateRecipeFormModel
            {
                Categories = this.GetAllCategories(),
                Cuisines = this.GetAllCuisines(),
                Difficulties = this.GetAllDfficulties(),
            };

            return View(recipe);
        }

        [HttpPost]
        public IActionResult Create(CreateRecipeFormModel recipe)
        {
            if (!ModelState.IsValid)
            {
                recipe.Categories = this.GetAllCategories();
                recipe.Cuisines = this.GetAllCuisines();
                recipe.Difficulties = this.GetAllDfficulties();
                return View(recipe);
            }

            var recipeData = new Recipe
            {
                Name = recipe.Name,
                Description = recipe.Description,
                Servings = recipe.Servings,
                CategoryId = recipe.CategoryId,
                CuisineId = recipe.CuisineId,
                DifficultyId = recipe.DifficultyId,
            };

            this.dbContext.Add(recipeData);
            //this.dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        private IEnumerable<CategoryViewModel> GetAllCategories()
        {
            var categories =
                this.dbContext
                    .Categories
                    .Select(c => new CategoryViewModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                    })
                    .ToList();

            return categories;
        }

        private IEnumerable<CuisineViewModel> GetAllCuisines()
        {
            var cuisines =
                this.dbContext
                    .Cuisines
                    .Select(c => new CuisineViewModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                    })
                    .ToList();

            return cuisines;
        }

        private IEnumerable<DifficultyViewModel> GetAllDfficulties()
        {
            var difficulties =
                this.dbContext
                    .Difficulties
                    .Select(c => new DifficultyViewModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                    })
                    .ToList();

            return difficulties;
        }
    }
}
