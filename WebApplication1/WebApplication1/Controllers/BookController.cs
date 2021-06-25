using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _1811061153.Controllers
{
    public class BookController : Controllers
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
