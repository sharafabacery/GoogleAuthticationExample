using Microsoft.AspNetCore.Mvc;

namespace GoogleAuthticationExample.Controllers
{
    public class LoginGoogle : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
