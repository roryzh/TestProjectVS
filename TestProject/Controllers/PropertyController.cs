using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Models;

// For more information on enabling MVC for empty projects, visit 

namespace TestProject.Controllers
{
    public class PropertyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Display()
        {
            var property = new Property() {Address = "XXX", Price = 1000 };
            ViewData["Message"] = "Your contact page.";
            return View(property);
        }

        public void getData(){


        }
    }
}
