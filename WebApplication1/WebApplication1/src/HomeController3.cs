using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    public class HomeController3 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
