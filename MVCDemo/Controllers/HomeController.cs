namespace MVCDemo.Controllers;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Diagnostics;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Name(string name)
    {
        ViewData["Hello"]="Hello "+name +", how are you today?";
        var cnnstr = Environment.GetEnvironmentVariable("mongoCnn");
        ViewData["Cnn"] = cnnstr;
        return View("Index");
    }
}
