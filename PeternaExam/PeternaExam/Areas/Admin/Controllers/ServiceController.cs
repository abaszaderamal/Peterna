using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeternaExam.Data.DAL;
using PeternaExam.Data.Entities;
using PeternaExam.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeternaExam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeViewModel HomeVM = new HomeViewModel
            {
                Services = await _context.Services.Where(s => s.IsDeleted == false).ToListAsync()
            };
            return View(HomeVM);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Service service)
        {
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            var dbService = await _context.Services.FindAsync(id);
            if (dbService == null) return BadRequest();
            return View(dbService);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Service service)
        {
            var dbService = await _context.Services.FindAsync(id);
            if (dbService == null) return BadRequest();

            dbService.Icon = service.Icon;
            dbService.Info = service.Info;
            dbService.Title = service.Title;
            dbService.Info2 = service.Info2;
            _context.Services.Update(dbService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var dbService = await _context.Services.FindAsync(id);
            if (dbService == null) return BadRequest();

            _context.Services.Remove(dbService);
             await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
