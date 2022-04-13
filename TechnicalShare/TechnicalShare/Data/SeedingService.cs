using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Models;
using System.Globalization;

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

            Expertise expertise = new Expertise(1, "adobe");
            Expertise expertise2 = new Expertise(2, "back-end");
            Expertise expertise3 = new Expertise(3, "cloud computing");
            Expertise expertise4 = new Expertise(4, "c#");
            Expertise expertise5 = new Expertise(5, "data science");
            Expertise expertise6 = new Expertise(6, "devops");
            Expertise expertise7 = new Expertise(7, "front-end");
            Expertise expertise8 = new Expertise(8, "html e css");
            Expertise expertise9 = new Expertise(9, "java");
            Expertise expertise10 = new Expertise(10, "javascript");
            Expertise expertise11 = new Expertise(11, "mobile");
            Expertise expertise12 = new Expertise(12, "node.js");
            Expertise expertise13 = new Expertise(13, "php");
            Expertise expertise14 = new Expertise(14, "product design");
            Expertise expertise15 = new Expertise(15, "python");
            Expertise expertise16 = new Expertise(16, "react");
            Expertise expertise17 = new Expertise(17, "ui/ux design");

                        

            Mentor mentor1 = new Mentor { Name = "João", Email = "joao@gmail.com", Position = "Desenvolvedor Front-end", Level = Models.Enums.Level.pleno, Expertise = expertise8, Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Password = "123456" };
            Mentor mentor2 = new Mentor { Name = "Maria", Email = "mariana@hotmail.com", Position = "DevOps", Level = Models.Enums.Level.pleno, Expertise = expertise6, Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "16:00h", Slot1 = "17:00h", Slot2 = "17:00h", Password = "12233445" };



            _context.Expertise.AddRange(expertise, expertise2, expertise3, expertise4, expertise5, expertise6, expertise7, expertise8,
                expertise9, expertise10, expertise11, expertise12, expertise13, expertise14, expertise15, expertise16, expertise17);
            _context.Mentor.AddRange(mentor1, mentor2);
            _context.SaveChanges();
        }

    }
}
