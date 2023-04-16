using Microsoft.AspNetCore.Mvc;

namespace Movies.Controllers
{
    public class AddAMovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
