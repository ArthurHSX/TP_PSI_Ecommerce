using Microsoft.AspNetCore.Mvc;
using Ecommerce_PSI.Models;

namespace Ecommerce_PSI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            //Usuario usuario = new Usuario()
            //{
            //    Username = "gustavo.caldeira",
            //    Email = "gustavo.caldeira@sga.pucminas.br",
            //    Nome = "Gustavo Caldeira",
            //    Senha = "1234"
            //};

            //usuario.ManterCadastro(usuario);

            //return View(usuario);

            return View();
        }
    }
}
