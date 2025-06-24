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
        juego.LSalas = juego.InicializarSalas();
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View();
    } 
    

      public IActionResult Historia()
    {
        return View("Historia");
    }
    public IActionResult Integrantes()
    {
        return View("Integrantes");
    }
    public IActionResult Sala1()
    {
        
        
        return View("sala1");
    }
    public IActionResult preg1()
    {
        return View();
    }
    [HttpPost]
    public IActionResult preg1(string claveIngresada)
{
    string juegoString = HttpContext.Session.GetString("juego");
    Juego? juego = Objeto.StringToObject<Juego>(juegoString);
    Sala salaActual = juego.LSalas[0];
    bool TF = salaActual.ValidarClave(claveIngresada);
    if (TF==true)
    {
        return View("Sala2");
    }
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
