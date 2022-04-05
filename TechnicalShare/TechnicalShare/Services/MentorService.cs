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

    }
}
