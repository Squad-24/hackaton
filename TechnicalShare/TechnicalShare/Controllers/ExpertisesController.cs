using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Controllers
{
    public class ExpertisesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
