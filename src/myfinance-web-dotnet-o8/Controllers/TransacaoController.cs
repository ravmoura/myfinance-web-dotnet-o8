using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet_o8.Models;
using myfinance_web_dotnet_o8.Services;
using myfinance_web_dotnet_o8.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace myfinance_web_dotnet_o8.Controllers
{
    [Route("[controller]")]
    public class TransacaoController : Controller
    {
        private readonly ILogger<TransacaoController> _logger;
        private readonly ITransacaoService _TransacaoService;
        private readonly IPlanoContaService _PlanoContaService;

        public TransacaoController(ILogger<TransacaoController> logger, ITransacaoService TransacaoService, IPlanoContaService PlanoContaService)
        {
            _logger = logger;
            _TransacaoService = TransacaoService;
            _PlanoContaService = PlanoContaService;
        }

        public IActionResult Index()
        {
            ViewBag.ListaTransacao = _TransacaoService.ListarRegistros();
            return View();
        }

    [HttpGet("Cadastro")]
    public IActionResult Cadastro()
    {
        var listaPlanoContas = _PlanoContaService.ListarRegistros();
        var planoContaSelectItens = new SelectList(listaPlanoContas, "Id", "Nome");

        var transacaoModel = new TransacaoModel
        {
            Data = DateTime.Now,
            PlanoContas = planoContaSelectItens
        };           
        return View(transacaoModel);
    }

    [HttpGet("Cadastro/{id}")]
    public IActionResult Cadastro(int id)
    {
        var registro = _TransacaoService.RetornarRegistro(id);            
        var listaPlanoContas = _PlanoContaService.ListarRegistros();
        var planoContaSelectItens = new SelectList(listaPlanoContas, "Id", "Nome");

        var TransacaoModel = new TransacaoModel
        {
            Id = registro.Id,
            Historico = registro.Historico,
            Tipo = registro.ItemPlanoConta.Tipo,
            Data = registro.Data,
            Valor = registro.Valor,
            PlanoContaId = registro.PlanoContaId,
            PlanoContas = planoContaSelectItens                             
        };
        return View(TransacaoModel);
    }

    [HttpPost("Cadastro")]
    [HttpPost("Cadastro/{id}")]
    public IActionResult Cadastro(TransacaoModel model, int? id)
    {
        if (ModelState.IsValid)
        {
            var Transacao = new Transacao
            {
                Id = model.Id,
                Historico = model.Historico,
                Data = model.Data,
                Valor = model.Valor,
                PlanoContaId = model.PlanoContaId
            };
            _TransacaoService.Salvar(Transacao);
        }
        return RedirectToAction("Index");        
    }

        [HttpGet]
        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _TransacaoService.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}