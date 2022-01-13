using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        public IActionResult Index(int luck)
        {
            //TODO: return this Action's View, passing it a new Spin Model object with it's Luck property set to luck
            // (HINT: you can do this in one short line of code)
            Spin spin = new Spin();
            spin.Luck = luck;
            return View(spin);
        }
    }
}