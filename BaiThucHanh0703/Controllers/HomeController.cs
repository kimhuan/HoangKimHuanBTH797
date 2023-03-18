using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;
using BaiThucHanh0703.Models.Process;


namespace BaiThucHanh0703.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
    GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(double a, double b, double c)

    { 
        string mess = gpt.GiaiPhuongTrinhBac2(a, b, c);
        ViewBag.ketqua = mess;
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
}
