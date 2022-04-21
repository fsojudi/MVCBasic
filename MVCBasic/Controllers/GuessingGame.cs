using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCBasic.Models;

namespace MVCBasic.Controllers
{
    public class GuessingGame : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int guessNumber)
        {
            Random random = new Random();
            int randomNumber = random.Next(100);
            int guess = 1;
            while ( guess<10)
            {
            ViewBag.Result1 = randomNumber;
            ViewBag.Result2 = Game.CheckGame(guessNumber,randomNumber);
                guess++;
            }
            return View();
        }
    }
}
