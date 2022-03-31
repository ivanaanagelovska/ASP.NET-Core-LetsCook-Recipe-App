namespace LetsCook.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class VideosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
