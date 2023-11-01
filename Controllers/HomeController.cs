using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EncuestaDojo.Models;

namespace EncuestaDojo.Controllers;

public class HomeController : Controller
{
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    //[HttpPost]
    [Route("")]
    public IActionResult Index(string nombre, string apellido, string ubicacion, string lenguaje, string descripcion)
    {
    return View();
    }


    [HttpPost] 
    [Route("/resul")]
    public IActionResult ProcessForm(string nombre, string apellido, string ubicacion, string lenguaje, string descripcion)
    {
        List<string> lista = new List<string>
        {
            nombre,
            apellido,
            ubicacion,
            lenguaje,
            descripcion
        };

        return View("Privacy", lista);
    }



    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
