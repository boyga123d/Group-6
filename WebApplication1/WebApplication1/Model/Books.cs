using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace 1811061153
{
    public class Books : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
