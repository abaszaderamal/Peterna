using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            HomeViewModel HomeVM = new HomeViewModel
            {
                
            };
            return View();
        }
    }
}
