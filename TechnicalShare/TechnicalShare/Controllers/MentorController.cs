using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Data;
using TechnicalShare.Services;
using TechnicalShare.Models;

namespace TechnicalShare.Controllers
{
    public class MentorController : Controller        
    {
        private readonly MentorService _mentorService;

        public MentorController(MentorService mentorService)
        {
            _mentorService = mentorService;
        }
        public IActionResult Index()
        {
            var list = _mentorService.FindAll();
            return View(list);
        }

        public IActionResult Frontend()
        {
            var list = _mentorService.FilterById(1);
            return View(list);
        }

        public IActionResult BackEnd()
        {
            var list = _mentorService.FilterById(2);
            return View(list);
        }

        public IActionResult Profile(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _mentorService.FindbyId(id.Value);

            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        public IActionResult Register()
        {
            return View();
        }

    }
}
