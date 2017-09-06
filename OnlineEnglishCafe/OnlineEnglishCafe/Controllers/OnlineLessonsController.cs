using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineEnglishCafe.Controllers
{
    public class OnlineLessonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}