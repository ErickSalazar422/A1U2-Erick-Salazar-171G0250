using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Actividad1.Controllers
{
    public class NumerosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}