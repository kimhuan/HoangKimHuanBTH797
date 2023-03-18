using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;
using BaiThucHanh0703.Models.Process;

namespace BaiThucHanh0703.Controllers;

public class StringProcessController : Controller
{
    private readonly ILogger<StringProcessController> _logger;
    
    StringProcess strPro = new StringProcess();
    public StringProcessController(ILogger<StringProcessController> logger)
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
    public IActionResult LowerToUpper()
        {
            return View();
        }
        public IActionResult UpperToLower()
        {
            return View();
        }
        public IActionResult HelloWorld()
        {
            return View();
        }

         [HttpPost]
        public IActionResult LowerToUpper(string strInput)
        {
            string strResult = strPro.LowerToUpper(strInput);
            ViewBag.bao= strResult;
            return View();
        }
        [HttpPost]
        public IActionResult UpperToLower(string strInput)
        {
            string strResult = strPro.UpperToLower(strInput);
            ViewBag.mess= strResult;
            return View();
        }

        [HttpPost]
        public IActionResult HelloWorld(string fullName)
        {
            string strResult = strPro.HelloWorld("Hello" + strPro.LowerToUpper(fullName));
            ViewBag.ket= strResult;
            return View();
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
