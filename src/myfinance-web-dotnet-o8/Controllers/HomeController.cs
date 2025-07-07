using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfiance_web_dotnet_o8.Models;
using myfinance_web_dotnet_o8.Infraestrutucture;

namespace myfiance_web_dotnet_o8.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MyFinanceDbContext _banco;
    public HomeController(ILogger<HomeController> logger, MyFinanceDbContext banco)
    {
        _logger = logger;
        _banco = banco;
    }

    public IActionResult Index()
    {
        var nomePrimeiroItemPlanoConta = _banco.PlanoConta.FirstOrDefault().Nome;
        ViewBag.Teste = nomePrimeiroItemPlanoConta;
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PUC()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
