using Microsoft.AspNetCore.Mvc;

namespace Atividade_de_Reposição.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
