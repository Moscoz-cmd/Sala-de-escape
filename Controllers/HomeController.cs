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

    public IActionResult Index(int numeroSala, string claveIngresada, Sala salaBuscada)
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
  


}
