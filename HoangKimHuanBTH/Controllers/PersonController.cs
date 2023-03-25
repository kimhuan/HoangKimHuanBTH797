using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HoangKimHuanBTH.Models;

namespace HoangKimHuanBTH.Controllers;

public class PersonController : Controller
{
    public IActionResult About()
    {
        return View();
    }
    [HttpPost]
    
    public IActionResult About(Person str)
    {
        string mess = str.MaCongDan + " - " + str.TenCongDan + " - " + str.PhoneNumber;
        ViewBag.thongBao = mess;
        return View();
    }
}

