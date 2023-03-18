using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;
using BaiThucHanh0703.Models.Process;

namespace BaiThucHanh0703.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;
    GiaiPhuongTrinh GPT = new GiaiPhuongTrinh();
    public bool StringIsNullOrEmpty { get; private set; }

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        return View();
    }

    public IActionResult Tinhtong()
    {
        return View();
    }
    public IActionResult Phuongtrinhbac2()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string FullName)
    {
        string stdResult = "Hello " + FullName;
        ViewBag.abc = stdResult;
        return View();
    }
    [HttpPost]
    public IActionResult Tinhtong(string Number)
    {
        int so = Convert.ToInt32(Number);
        int tong = 0;
        while(so > 0 )
        {
           tong = tong + so%10;
           so = so/10;
        }
        ViewBag.message = tong;
        return View();
    }
    [HttpPost]
         public IActionResult Phuongtrinhbac2(string NumA, string NumB, string NumC)
        {
            double a = 0, b=0, c=0;
            //Giai phuong trinh
            if(!String.IsNullOrEmpty(NumA)) a = Convert.ToDouble(NumA);
            if(!String.IsNullOrEmpty(NumB)) b = Convert.ToDouble(NumB);
            if(!String.IsNullOrEmpty(NumC)) c = Convert.ToDouble(NumC);
            string note = GPT.GiaiPhuongTrinhBac2(a, b, c);
            
            ViewBag.ketqua = note;
            return View();
        }
    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
