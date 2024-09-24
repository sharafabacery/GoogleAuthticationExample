using GoogleAuthticationExample.Repositories.Interfance;
using Microsoft.AspNetCore.Mvc;

namespace GoogleAuthticationExample.Controllers
{
    public class LoginGoogle : Controller
    {
        private readonly ILoginGoogleService loginGoogleService;

        public LoginGoogle(ILoginGoogleService loginGoogleService)
        {
            this.loginGoogleService = loginGoogleService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
