using FrontToBackForPratick.DAL;
using FrontToBackForPratick.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackForPratick.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Card slider = _context.Cards.FirstOrDefault();
            return View();
        }
    }
}
