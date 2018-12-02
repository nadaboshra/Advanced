using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SnowBoardingProject_Core.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Event()
        {
            return View();
        }
    }
}