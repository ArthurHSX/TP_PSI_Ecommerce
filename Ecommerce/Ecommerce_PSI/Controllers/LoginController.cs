using Microsoft.AspNetCore.Mvc;
using Ecommerce_PSI.Models;

namespace Ecommerce_PSI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
