using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCBasic.Models;

namespace MVCBasic.Controllers
{
    public class Doctor : Controller
    {
        
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Index(double temp, string type)
            {

                ViewBag.Fever = CheckFever.Check(temp, type);

                return View();
            }
       
    }
}
