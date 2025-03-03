using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ornek.Models;

namespace Ornek.Controllers;

public class HomeController : Controller
{
     private ApplicationDbContext _veritabani;
    private readonly ILogger<HomeController> _logger;
    

    public HomeController(ILogger<HomeController> logger,ApplicationDbContext veritabani)
    {
        _logger = logger;
        _veritabani = veritabani;
    }

    public IActionResult Index()
    {
        var liste = _veritabani.Ogretmenler.ToList();
        return View(liste);
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
