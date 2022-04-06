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
            if (!_context.Expertise.Any() || !_context.MentorMentee.Any() || !_context.Mentor.Any() || !_context.Mentee.Any())
            {
                Expertise expertise = new Expertise("front-end");
                Expertise expertise2 = new Expertise("back-end");
                Mentor mentor1 = new Mentor(3, "Billy", "billy@hotmail.com", "1234567", "desenvolvedor front-end", Models.Enums.Level.MidLevel, expertise);
                Mentor mentor2 = new Mentor(4, "Anna", "anna@hotmail.com", "1234567", "desenvolvedora back-end", Models.Enums.Level.Junior, expertise2);

                _context.Expertise.AddRange(expertise, expertise2);
                _context.Mentor.AddRange(mentor1, mentor2);
                _context.SaveChanges();
            }

            
        }

    }
}
