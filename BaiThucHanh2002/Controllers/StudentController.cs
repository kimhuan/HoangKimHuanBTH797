using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace BaiThucHanh2002.Controllers
{

    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}