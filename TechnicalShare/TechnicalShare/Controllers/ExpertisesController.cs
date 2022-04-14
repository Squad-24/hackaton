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
        private readonly IExpertiseService _expertiseService;
        public ExpertisesController(IExpertiseService expertiseService)
        {

            _expertiseService = expertiseService;

        }
        public IActionResult Index()
        {
            var list = _expertiseService.FindAll();
            return View(list);
        }

        public IActionResult BackEnd()
        {
            var list = _expertiseService.FilterById(1);
            return View(list);
        }
        public IActionResult Cplusplus()
        {
            var list = _expertiseService.FilterById(2);
            return View(list);
        }

        public IActionResult Csharp()
        {
            var list = _expertiseService.FilterById(3);
            return View(list);
        }

        public IActionResult DataScience()
        {
            var list = _expertiseService.FilterById(4);
            return View(list);
        }

        public IActionResult DevOps()
        {
            var list = _expertiseService.FilterById(5);
            return View(list);
        }

        public IActionResult Fullstack()
        {
            var list = _expertiseService.FilterById(6);
            return View(list);
        }
        public IActionResult FrontEnd()
        {
            var list = _expertiseService.FilterById(7);
            return View(list);
        }

        public IActionResult HtmlCss()
        {
            var list = _expertiseService.FilterById(8);
            return View(list);
        }

        public IActionResult Java()
        {
            var list = _expertiseService.FilterById(9);
            return View(list);
        }
        public IActionResult Javascript()
        {
            var list = _expertiseService.FilterById(10);
            return View(list);
        }

        public IActionResult Mobile()
        {
            var list = _expertiseService.FilterById(11);
            return View(list);
        }

        public IActionResult Php()
        {
            var list = _expertiseService.FilterById(12);
            return View(list);
        }

        public IActionResult ProductDesign()
        {
            var list = _expertiseService.FilterById(13);
            return View(list);
        }

        public IActionResult ProductOwner()
        {
            var list = _expertiseService.FilterById(14);
            return View(list);
        }
        public IActionResult Python()
        {
            var list = _expertiseService.FilterById(15);
            return View(list);
        }


        public IActionResult UXUI()
        {
            var list = _expertiseService.FilterById(16);
            return View(list);
        }
     














    }
}
