using Microsoft.AspNetCore.Mvc;

namespace templeteTest.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
