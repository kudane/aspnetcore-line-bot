using Microsoft.AspNetCore.Mvc;

namespace Application.LineLiff.Controllers
{
    public class SignInController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}