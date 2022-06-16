using ColorlibBack.DAL;
using ColorlibBack.Models;
using ColorlibBack.Utilies.Extension;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ColorlibBack.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BreakfastController : Controller
    {
        public AppDbContext _context { get; }
        private readonly IWebHostEnvironment _env;


        public BreakfastController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Breakfasts);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Breakfast breakfast)
        {
            if (breakfast.Photo.CheckSize(800))
            {
                ModelState.AddModelError("Photo", "File size must be less than 800kb");
                return View();
            }
            if (!breakfast.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "File must be image");
                return View();
            }
            breakfast.Image = await breakfast.Photo.SaveFileAsync(Path.Combine(_env.WebRootPath, "image"));
            await _context.Breakfasts.AddAsync(breakfast);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Breakfast breakfast = _context.Breakfasts.Find(id);
            if (breakfast == null) return NotFound();
            if (System.IO.File.Exists(Path.Combine(_env.WebRootPath, "image", breakfast.Image)))
            {
                System.IO.File.Delete(Path.Combine(_env.WebRootPath, "image", breakfast.Image));
            }
            _context.Breakfasts.Remove(breakfast);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id)
        {
            Breakfast breakfast = _context.Breakfasts.FirstOrDefault(c => c.Id == id);
            if (breakfast == null) return NotFound();
            return View(breakfast);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Breakfast breakfast)
        {
            if (ModelState.IsValid)
            {
                var s = await _context.Breakfasts.FindAsync(breakfast.Id);
                s.Name = breakfast.Name;
                s.Desc = breakfast.Desc;
                if (breakfast.Photo != null)
                {
                    if (breakfast.Image != null)
                    {
                        string filePath = Path.Combine(_env.WebRootPath, "image", breakfast.Image);
                        System.IO.File.Delete(filePath);
                    }
                    s.Image = ProcessUploadedFile(breakfast);
                }
                _context.Update(s);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        private string ProcessUploadedFile(Breakfast breakfast)
        {
            string uniqueFileName = null;

            if (breakfast.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "image");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + breakfast.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    breakfast.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}