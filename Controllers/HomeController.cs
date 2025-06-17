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
        Juego juego = new Juego();

        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View();
    } 
    public IActionResult Sala1()
    {
        return View("sala1");
    }

      public IActionResult Historia()
    {
        return View("Historia");
    }
    public IActionResult Integrantes()
    {
        return View("Integrantes");
    }
    public IActionResult preg1(string claveIngresada ,int numeroSala, Sala salaBuscada)
    {
        
        return View("preg1");
    }
    public IActionResult Sala2()
    {
        return View("Sala2");
    }
    public IActionResult preg2()
    {
        return View("preg2");
    }
    public IActionResult sala3()
    {
        return View("sala3");
    }
    public IActionResult preg3()
    {
        return View("preg3");
    }
    public IActionResult sala4()
    {
        return View("sala4");
    }
    public IActionResult preg4()
    {
        return View("preg4");
    }


}
