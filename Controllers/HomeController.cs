using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerProyecto.Models;

namespace PrimerProyecto.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Sala1()
    {
        return View("Juego");
    }

      public IActionResult Sala2()
    {
        return View("Historia");
    }
    public IActionResult Sala3()
    {
        return View("Integrantes");
    }
  


}
