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
    public class MentorsController : Controller        
    {
        private readonly MentorService _mentorService;

        public MentorsController(MentorService mentorService)
        {
            _mentorService = mentorService;
        }
        public IActionResult Index()
        {
            var list = _mentorService.FindAll();
            return View(list);
        }
        public IActionResult Agendar(int id)
        {
            CalendarMentor calendarMentor = new CalendarMentor();

            var mentor = _mentorService.FindbyId(id);
            calendarMentor.Mentor = mentor;
            calendarMentor.MentorId = id;
            return View(calendarMentor);
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
    }
}
