using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasic.Controllers
{
    public class GuessingGame : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
