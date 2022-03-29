using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kuo_Thomas_HW1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult AboutMe()
        {
            return View();
        }
        public ViewResult Personal()
        {
            return View();
        }
        public ViewResult Projects()
        {
            return View();
        }
    }
}
