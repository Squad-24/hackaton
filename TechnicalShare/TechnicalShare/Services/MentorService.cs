using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Data;
using TechnicalShare.Models;
using Microsoft.AspNetCore.Identity;

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
             
        public void Insert(Mentor obj)
        {           
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Schedule(DateTime schedule)
        {
            int day = schedule.Day;
            string slot = schedule.Hour.ToString("HH:mm" + "h");
            _context.AddRange(day, slot);
            _context.SaveChanges();
        }
        
        public bool Validate(string email, string password)
        {
            var validate = _context.Mentor.Where(obj => obj.Email.Equals(email) && obj.Password.Equals(password)).FirstOrDefault();

            if(validate != null)
            {
                return true;
            }

            return false;
            
        }
     
    }
}
