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
        private readonly ExpertiseService _expertiseService;       
        public ExpertisesController(ExpertiseService expertiseService)
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

        public IActionResult DevOps()
        {
            var list = _expertiseService.FilterById(2);
            return View(list);
        }

        public IActionResult FrontEnd()
        {
            var list = _expertiseService.FilterById(3);
            return View(list);
        }

        public IActionResult Mobile()
        {
            var list = _expertiseService.FilterById(4);
            return View(list);
        }

        public IActionResult ProductManagement()
        {
            var list = _expertiseService.FilterById(5);
            return View(list);
        }

        public IActionResult UIDesign()
        {
            var list = _expertiseService.FilterById(6);
            return View(list);
        }

        public IActionResult UXDesign()
        {
            var list = _expertiseService.FilterById(7);
            return View(list);
        }

    }
}
