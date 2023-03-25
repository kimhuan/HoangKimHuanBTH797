using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2003.Models;

namespace BaiThucHanh2003.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student std)
    {
        string ketqua = std.StudentCode + " " + std.FullName + " " + std.Address;
        ViewBag.message = ketqua;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
