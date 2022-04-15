﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Data;
using TechnicalShare.Services;
using TechnicalShare.Models;
using TechnicalShare.Models.ViewModels;

namespace TechnicalShare.Controllers
{
    public class MentorsController : Controller
    {
        private readonly MentorService _mentorService;
        private readonly ExpertiseService _expertiseService;
        private readonly TechnicalShareContext _context;

        public MentorsController(MentorService mentorService, ExpertiseService expertiseService, TechnicalShareContext context)
        {
            _mentorService = mentorService;
            _expertiseService = expertiseService;
            _context = context;
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
            if (id == null)
            {
                return NotFound();
            }

            var obj = _mentorService.FindbyId(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        public IActionResult Register()
        {
            var expertises = _expertiseService.FindAll();
            var viewModel = new MentorFormViewModel { Expertises = expertises };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Mentor mentor)
        {
            _mentorService.Insert(mentor);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var find = _mentorService.Validate(login.Email, login.Password);

            if (find is true)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "login inválido");
            }

            return RedirectToAction("Index", "Home");    //View(login); 
        }


        public IActionResult Agendar(int id)
        {
            CalendarMentor calendarMentor = new CalendarMentor();

            var mentor = _mentorService.FindbyId(id);
            calendarMentor.Mentor = mentor;
            calendarMentor.MentorId = id;
            return View(calendarMentor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Profile(DateTime schedule)
        {
            _mentorService.Schedule(schedule);
            return RedirectToAction(nameof(Agendar));

        }

    }
}
