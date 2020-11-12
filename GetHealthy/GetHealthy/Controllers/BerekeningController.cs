using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GetHealthy.Controllers
{
    public class BerekeningController : Controller
    {
        public IActionResult Uitkomst()
        {
            return View();
        }
    }
}
