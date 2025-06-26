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
            HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
            return View("Sala2");
        }
        
        return View("preg1");
    }
    [HttpPost]
    public IActionResult sala2(string claveIngresada)
    {
        string juegoString = HttpContext.Session.GetString("juego");
        Juego? juego = Objeto.StringToObject<Juego>(juegoString);

        Sala salaActual = juego.LSalas[1];
        bool TF = salaActual.ValidarClave(claveIngresada);
    if (TF==true)
    {
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View("Sala3");
    }
    
    return View("Sala2");
        
    }
    
    [HttpPost]
    public IActionResult sala3(string claveIngresada)
    {
        string juegoString = HttpContext.Session.GetString("juego");
        Juego? juego = Objeto.StringToObject<Juego>(juegoString);
        Sala salaActual = juego.LSalas[2];
        bool TF = salaActual.ValidarClave(claveIngresada);
        if (TF==true)
        {
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View("Sala35");
        }
       
        return View("sala3");
    }
    public IActionResult Sala35(string claveIngresada)
    {
        string juegoString = HttpContext.Session.GetString("juego");
        Juego? juego = Objeto.StringToObject<Juego>(juegoString);
        Sala salaActual = juego.LSalas[3];
        bool TF = salaActual.ValidarClave(claveIngresada);
        if (TF==true)
        {
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View("sala4");
        }
        return View("Sala3");
    }
    public IActionResult sala4(string claveIngresada)
    {   
        string juegoString = HttpContext.Session.GetString("juego");
        Juego? juego = Objeto.StringToObject<Juego>(juegoString);
        Sala salaActual = juego.LSalas[4];
        bool TF = salaActual.ValidarClave(claveIngresada);
        if (TF==true)
        {
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View("salaF");
        }
        return View("sala4");

    }
    public IActionResult preg4()
    {
        return View("preg4");
    }
}

