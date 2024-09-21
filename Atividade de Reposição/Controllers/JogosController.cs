using Atividade_de_Reposição.Models;
using Microsoft.AspNetCore.Mvc;

public class JogosController : Controller
{
 
    public IActionResult Index()
    {
        var jogos = new List<Jogo>
        {
            new Jogo { Id = 1, Nome = "Super Mario", Genero = "Plataforma", DesenvolvedorId = 1 },
            new Jogo { Id = 2, Nome = "The Witcher 3", Genero = "RPG", DesenvolvedorId = 2 }
        };
        return View(jogos); 
    }
}
