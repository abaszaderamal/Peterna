using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeternaExam.Data.DAL;
using PeternaExam.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeternaExam.Controllers
{

    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            HomeViewModel HomeVM = new HomeViewModel
            {
                Services = await _context.Services.Where(s=>s.IsDeleted==false).ToListAsync()
            };
            return View(HomeVM);
        }
    }
}
