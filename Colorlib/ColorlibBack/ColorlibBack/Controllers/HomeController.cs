using ColorlibBack.DAL;
using ColorlibBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ColorlibBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Breakfasts = await _context.Breakfasts.ToListAsync(),
                Brunches = await _context.Brunches.ToListAsync(),
                Dinners = await _context.Dinners.ToListAsync()
            };
            return View(homeVM);
        }

        
    }
}
