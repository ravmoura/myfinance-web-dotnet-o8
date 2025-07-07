using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet_o8.Domain;
using myfinance_web_dotnet_o8.Infraestrutucture;
using myfinance_web_dotnet_o8.Models;
using myfinance_web_dotnet_o8.Services;

namespace myfiance_web_dotnet_o8.Controllers;

[Route("[controller]")]
public class PlanoContaController : Controller
{
    private readonly ILogger<PlanoContaController> _logger;
    private readonly IPlanoContaService _planoContaService;
    

    public PlanoContaController(ILogger<PlanoContaController> logger, IPlanoContaService planoContaService)
    {
        _logger = logger;
        _planoContaService = planoContaService;
    }

    public IActionResult Index()
    {        
        ViewBag.ListaPlanoConta =  _planoContaService.ListarRegistros();
        return View();
    }

    [HttpPost]
    [HttpGet]    
    [Route("Cadastro")]
    [Route("Cadastro/{id}")]
    public IActionResult Cadastro(PlanoContaModel? model, int? id){
        if (id != null && !ModelState.IsValid)
        { //Carregar o registro em tela para alteração
            var registro = _planoContaService.RetornarRegistro((int)id);

            var planoContaModel = new PlanoContaModel()
            {
                Id = registro.Id,
                Nome = registro.Nome,
                Tipo = registro.Tipo
            };
            return View(planoContaModel);

        } 
        //Salvar novo registro
        else if (model != null && ModelState.IsValid)
        {
            var planoConta = new PlanoConta
            {
                Id = model.Id,
                Nome = model.Nome,
                Tipo = model.Tipo
            };
            _planoContaService.Salvar(planoConta);
            return RedirectToAction("Index");
        }
        //Carregar tela em branco
        else
        {
            return View();
        }        
    }

    [HttpGet]
    [Route("Excluir/{id}")]
    public IActionResult Excluir(int id){
        _planoContaService.Excluir(id);
        return RedirectToAction("Index");
    }
}
