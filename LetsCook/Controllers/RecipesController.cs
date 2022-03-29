namespace LetsCook.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using LetsCook.Models.Recipes;
    public class RecipesController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AddRecipeFormModel recipe) 
        {
            return View();
        }
    }
}
