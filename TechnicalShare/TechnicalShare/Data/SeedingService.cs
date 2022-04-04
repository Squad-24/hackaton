using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Models;

namespace TechnicalShare.Data
{
    public class SeedingService
    {
        private readonly TechnicalShareContext _context;

        public SeedingService(TechnicalShareContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            // testando se já existe algum dado no banco de dados
            if (_context.Expertise.Any() || _context.User.Any() || _context.MentorMentee.Any())
            {
                return;
            }

            Expertise expertise1 = new Expertise(1, "front-end");
            Mentor mentor1 = new Mentor(1, "Alex Brown", "alexbrown@gmail.com", "123456", expertise1, Models.Enums.Level.MidLevel);
            Mentee mentee1 = new Mentee(2, "Maria Green", "mariagreen@hotmail.com", "123456", expertise1);
                       
            _context.SaveChanges();
        }

    }
}
