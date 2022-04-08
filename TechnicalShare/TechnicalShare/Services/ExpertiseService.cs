using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Data;
using TechnicalShare.Models;

namespace TechnicalShare.Services
{
    public class ExpertiseService
    {
        private readonly TechnicalShareContext _context;

        public ExpertiseService(TechnicalShareContext context)
        {
            _context = context;
        }

        public List<Expertise> FindAll()
        {
            return _context.Expertise.ToList();
        }
                     
        
        public Expertise FindbyId(int id)
        {
            return _context.Expertise.First(obj => obj.Id == id);
        }

        
    }
}
