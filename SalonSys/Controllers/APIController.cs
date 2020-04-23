using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalonSys.Controllers
{
    public class APIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}