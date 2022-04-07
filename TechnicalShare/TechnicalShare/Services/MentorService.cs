using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Data;
using TechnicalShare.Models;

namespace TechnicalShare.Services
{
    public class MentorService
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

        public List<Mentor> GetFrontEnd()
        {
            List<Mentor> mentores = _context.Mentor.Include(obj => obj.Expertise).ToList();
            var front = from mentor in mentores
                        where mentor.ExpertiseId == 1
                        select mentor;

            List<Mentor> FrontEnd = new List<Mentor>();
            foreach (Mentor mentor in front)
                FrontEnd.Add(mentor);

            return FrontEnd;
        }

        public List<Mentor> GetBackEnd()
        {
            List<Mentor> mentores = _context.Mentor.Include(obj => obj.Expertise).ToList();
            var back = from mentor in mentores
                        where mentor.ExpertiseId == 2
                        select mentor;

            List<Mentor> BackEnd = new List<Mentor>();
            foreach (Mentor mentor in back)
                BackEnd.Add(mentor);

            return BackEnd;
        }

        public Mentor AddMentor(Mentor mentor)
        {
            _context.Mentor.Add(mentor);
            _context.SaveChanges();
            return mentor;
        }
    }
}
