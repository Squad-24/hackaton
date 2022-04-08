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

        public IActionResult BackEnd(int id)
        {
            var list = _expertiseService.FindAll().Where(obj => obj.Id == id);
            return View(list);
        }              

        public IActionResult DevOps(int id)
        {
            var list = _expertiseService.FindAll().Where(obj => obj.Id == id);
            return View(list);
        }

        public IActionResult FrontEnd(int id)
        {
            var list = _expertiseService.FindAll().Where(obj => obj.Id == id);
            return View(list);
        }

        public IActionResult Mobile(int id)
        {
            var list = _expertiseService.FindAll().Where(obj => obj.Id == id);
            return View(list);
        }

        public IActionResult ProductManagement(int id)
        {
            var list = _expertiseService.FindAll().Where(obj => obj.Id == id);
            return View(list);
        }

        public IActionResult UIDesign(int id)
        {
            var list = _expertiseService.FindAll().Where(obj => obj.Id == id);
            return View(list);
        }

        public IActionResult UXDesign(int id)
        {
            var list = _expertiseService.FindAll().Where(obj => obj.Id == id);
            return View(list);
        }

    }
}
