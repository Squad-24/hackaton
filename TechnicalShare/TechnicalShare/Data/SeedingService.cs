using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Models;

namespace TechnicalShare.Data
{
    public class SeedingService : ISeedingService
    {
        private readonly TechnicalShareContext _context;

        public SeedingService(TechnicalShareContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            // testando se já existe algum dado no banco de dados
            if (_context.Expertise.Any() || _context.MentorMentee.Any() || _context.Mentor.Any() || _context.Mentee.Any())
            {
                return;
            }

            Expertise expertise = new Expertise(1, "back-end");
            Expertise expertise2 = new Expertise(2, "devops");
            Expertise expertise3 = new Expertise(3, "front-end");
            Expertise expertise4 = new Expertise(4, "mobile");
            Expertise expertise5 = new Expertise(5, "product management");
            Expertise expertise6 = new Expertise(6, "ui design");
            Expertise expertise7 = new Expertise(7, "ux design");            
            Mentor mentor2 = new Mentor("maria", "maria@hotmail.com", "1234567", "desenvolvedora full stack", Models.Enums.Level.senior, expertise);
            Mentor mentor6 = new Mentor("mariana", "mariana@hotmail.com", "1234567", "devops", Models.Enums.Level.senior, expertise2);
            Mentor mentor1 = new Mentor("joão", "joão@hotmail.com", "1234567", "desenvolvedor front-end", Models.Enums.Level.pleno, expertise3);
            Mentor mentor3 = new Mentor("paula", "paula@hotmail.com", "1234567", "desenvolvedora mobile", Models.Enums.Level.junior, expertise4);
            Mentor mentor4 = new Mentor("jorge", "jorge@hotmail.com", "1234567", "ui designer", Models.Enums.Level.pleno, expertise6);
            Mentor mentor5 = new Mentor("gustavo", "gustavo@hotmail.com", "1234567", "ux designer", Models.Enums.Level.senior, expertise7);            
            Mentor mentor7 = new Mentor("victor", "victor@hotmail.com", "1234567", "product manager", Models.Enums.Level.pleno, expertise5);



            _context.Expertise.AddRange(expertise, expertise2, expertise3, expertise4, expertise5, expertise6, expertise7);
            _context.Mentor.AddRange(mentor1, mentor2, mentor3, mentor4, mentor5, mentor6, mentor7);
            _context.SaveChanges();
        }

    }
}
