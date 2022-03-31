namespace LetsCook.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CookingClassesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
