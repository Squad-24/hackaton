using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Data;
using TechnicalShare.Models;

namespace TechnicalShare.Services
{
    public class MentorService : IMentorService
    {
        private readonly TechnicalShareContext _context;

        public MentorService(TechnicalShareContext context)
        {
            _context = context;
        }

        public List<Mentor> FindAll()
        {
            return _context.Mentor.Include(obj => obj.Expertise).ToList();
        }

        public Mentor FindbyId(int id)
        {
            return _context.Mentor.Include(obj => obj.Expertise).First(obj => obj.Id == id);
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

        public Mentor AddMentor(Mentor mentor)
        {
            _context.Mentor.Add(mentor);
            _context.SaveChanges();
            return mentor;
        }
    }
}
