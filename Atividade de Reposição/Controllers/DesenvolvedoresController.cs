using Atividade_de_Reposição.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_de_Reposição.Controllers
{
    public class DesenvolvedoresController : Controller
    {
       
        public IActionResult Index()
        {
            var desenvolvedores = new List<Desenvolvedor>
        {
            new Desenvolvedor { Id = 1, Nome = "Nintendo", Pais = "Japão" },
            new Desenvolvedor { Id = 2, Nome = "CD Projekt Red", Pais = "Polônia" }
        };
            return View(desenvolvedores); 
        }
    }



}
