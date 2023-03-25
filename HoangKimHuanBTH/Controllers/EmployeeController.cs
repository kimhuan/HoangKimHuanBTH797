using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HoangKimHuanBTH.Models;

namespace HoangKimHuanBTH.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    
    public IActionResult Index(Employee emp)
    {
        string mess = emp.EmployeeID + " - " + emp.EmployeeName + " - " + emp.PhoneNumber + " - " + emp.DiaChi + " - " + emp.ChucVu;
        ViewBag.show = mess;
        return View();
    }
}

