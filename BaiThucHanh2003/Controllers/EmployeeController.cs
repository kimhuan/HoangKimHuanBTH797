using System.ComponentModel.Design;
using System;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2003.Models;
using BaiThucHanh2003.Data;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh2003.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController (ApplicationDbContext context)
        {

            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Employee.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee std)
        {
            if(ModelState.IsValid)
            {
                _context.Employee.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(std);
        }
    }
}