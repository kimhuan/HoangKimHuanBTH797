using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;

namespace BaiThucHanh0703.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

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
            //khai bao bien
            double delta, x1, x2, a = 0, b = 0, c = 0;
            string ketqua;
            //Giai phuong trinh
            if(!String.IsNullOrEmpty(NumA)) a = Convert.ToDouble(NumA);
            if(!String.IsNullOrEmpty(NumB)) b = Convert.ToDouble(NumB);
            if(!String.IsNullOrEmpty(NumC)) c = Convert.ToDouble(NumC);
            if(a==0) ketqua = "Khong phai phuong trinh bac 2";
            else{
                //tinh delta
                delta = Math.Pow(b,2) - 4*a*c;
                // Giai phuong trinh
                if(delta<0) ketqua ="Phuong trinh vo nghiem";
                else if(delta==0)
                {
                    x1 = -b/(2*a);
                    ketqua ="Phuong trinh co nghiem kep = "+ x1;
                }
                else 
                {
                    x1= (-b + Math.Sqrt(delta))/(2*a);
                    x2= (-b - Math.Sqrt(delta))/(2*a);
                    ketqua = "Phuong trinh co 2 nghiem phan biet: x1 = "+ x1  +", x2 = "+ x2;
                }
            }
            ViewBag.thongbao = ketqua;
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
