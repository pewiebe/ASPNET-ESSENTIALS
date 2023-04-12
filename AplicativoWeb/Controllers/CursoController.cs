using AplicativoWeb.Models;//camada Modelo 1
using Microsoft.AspNetCore.Mvc; //Microsoft
namespace AplicativoWeb.Controllers; //Defimido
//Criamos a classe Controller
public class CursoController:Controller {
    public IActionResult Index (){
        Curso c1 = new Curso();
        // set
        c1.Descricao = "Primeiros Passos no ASP.NET Core";
        c1.TituloInterno = "Desenvolvedor C#";
        c1.TituloMarketing = "Crie Aplicativos Internos";

        //get
        ViewData["curso"] = c1; // Passando o objeto
        return View ();
        
    }

    public IActionResult Create(){
        ViewData["titulo"] = "Cadastro de Cursos";
        ViewBag.DataHora = DateTime.Now;
        return View ();
    }
}