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

        public List<Mentor> FilterById(int Id)
        {
            List<Mentor> mentores = _context.Mentor.Include(obj => obj.Expertise).ToList();
            var list = from mentor in mentores
                       where mentor.ExpertiseId == Id
                       select mentor;

            List<Mentor> FilteredList = new List<Mentor>();
            foreach (Mentor mentor in list)
                FilteredList.Add(mentor);

            return FilteredList;
        }
    }
}
