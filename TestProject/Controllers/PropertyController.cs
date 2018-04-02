using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using TestProject.Models;


// For more information on enabling MVC for empty projects, visit 

namespace TestProject.Controllers
{
    public class PropertyController : Controller
    {
        // GET: /<controller>


        public IActionResult Display()
        {

            var property1 = new Property() { Address = "2102 Kevin St, Tx", Year = 1990, Sqft=1100, Bedroom=1, Bathroom=1, Price = 100000 };
            var property2 = new Property() { Address = "3102 Belter St, Tx", Year = 1991, Sqft=1200, Bedroom = 2, Bathroom = 2, Price = 200000 };
            var property3 = new Property() { Address = "4102 Good St, Tx", Year = 1992, Sqft=1300, Bedroom = 3, Bathroom = 3, Price = 300000 };

            //ArrayList myProperties = new ArrayList();
            var myProperties = new List<Property>();
            myProperties.Add(property1);
            myProperties.Add(property2);
            myProperties.Add(property3);


            ViewData["Message"] = "Your contact page.";
            return View(myProperties);
        }

        //public void getData(){


        //}
    }
}
