using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Data;
using TechnicalShare.Models;
using TechnicalShare.Services;

namespace TechnicalShare.Controllers
{
    public class ExpertisesController : Controller
    {
        private readonly TechnicalShareContext _context;
        private readonly ExpertiseService _expertiseService;

        public ExpertisesController(TechnicalShareContext context, ExpertiseService expertiseService)
        {
            _context = context;
            _expertiseService = expertiseService;
        }
        public IActionResult Index()
        {
            var list = _expertiseService.FindAll();
            return View(list);
        }

      

    }
}
