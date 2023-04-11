using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
