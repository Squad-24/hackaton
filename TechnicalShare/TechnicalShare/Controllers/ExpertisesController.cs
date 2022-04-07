using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Data;
using TechnicalShare.Services;

namespace TechnicalShare.Controllers
{
    public class ExpertisesController : Controller
    {
        private readonly TechnicalShareContext _context;
        private readonly MentorService _mentorService;

        public ExpertisesController(TechnicalShareContext context, MentorService mentorService)
        {
            _context = context;
            _mentorService = mentorService;
        }
        public IActionResult Index()
        {
            var list = _mentorService.FindAll();
            return View(list);
        }
        
    }
}
