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

            Expertise expertise = new Expertise(1, "back-end");            
            Expertise expertise1 = new Expertise(2, "c++");
            Expertise expertise2 = new Expertise(3, "c#");
            Expertise expertise3 = new Expertise(4, "data science");
            Expertise expertise4 = new Expertise(5, "devops");
            Expertise expertise5 = new Expertise(6, "full stack");
            Expertise expertise6 = new Expertise(7, "front-end");
            Expertise expertise7 = new Expertise(8, "html e css");
            Expertise expertise8 = new Expertise(9, "java");
            Expertise expertise9 = new Expertise(10, "javascript");
            Expertise expertise10 = new Expertise(11, "mobile");            
            Expertise expertise11 = new Expertise(12, "php");
            Expertise expertise12 = new Expertise(13, "product design");
            Expertise expertise13 = new Expertise(14, "product owner");
            Expertise expertise14 = new Expertise(15, "python");            
            Expertise expertise15 = new Expertise(16, "ux/ui");



            Mentor mentor = new Mentor { Name = "Pedro Santos", Email = "pedrosantos@gmail.com", Expertise = expertise, Level = Models.Enums.Level.pleno, Position = "Engenheiro de software",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22,
                Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus." };
          
            
            Mentor mentor1 = new Mentor { Name = "Ana Beatriz Garcia", Email = "anabeatriz@gmail.com", Expertise = expertise15, Level = Models.Enums.Level.senior, Position = "UX designer",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22,
                Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus." };

            Mentor mentor2 = new Mentor
            {
                Name = "Luciana Amorim", Email = "luciana@hotmail.com", Expertise = expertise12, Level = Models.Enums.Level.senior, Position = "Product Designer",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor3 = new Mentor
            {
                Name = "Bruno Cavalcanti", Email = "brunoca@hotmail.com", Expertise = expertise6, Level = Models.Enums.Level.pleno, Position = "Desenvolvedor Front-end",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor4 = new Mentor
            {
                Name = "Alan Soares", Email = "alansoa@hotmail.com", Expertise = expertise6, Level = Models.Enums.Level.master, Position = "Engenheiro de software Front-end",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor5 = new Mentor
            {
                Name = "Luana Silveira", Email = "luanasilveiraa@hotmail.com", Expertise = expertise3, Level = Models.Enums.Level.pleno, Position = "Data Analyst",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor6 = new Mentor
            {
                Name = "Daniele Gimenes", Email = "danigimenes@hotmail.com", Expertise = expertise2, Level = Models.Enums.Level.junior, Position = "Desenvolvedora C#",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor7 = new Mentor
            {
                Name = "Bianca C. Lourenço", Email = "biancalou@hotmail.com", Expertise = expertise13, Level = Models.Enums.Level.pleno, Position = "Product Owner",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor8 = new Mentor
            {
                Name = "Amanda Souza", Email = "aamanda@hotmail.com", Expertise = expertise5, Level = Models.Enums.Level.pleno, Position = "Desenvolvedora Full Stack",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor9 = new Mentor
            {
                Name = "Natalia Silva", Email = "natsl@hotmail.com", Expertise = expertise4, Level = Models.Enums.Level.senior, Position = "Engenheira DevOps",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor10 = new Mentor
            {
                Name = "Felipe Soares", Email = "felsoar@hotmail.com", Expertise = expertise11, Level = Models.Enums.Level.pleno, Position = "Desenvolvedor PHP",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor11 = new Mentor
            {
                Name = "Yago Mendes", Email = "yagomen@hotmail.com", Expertise = expertise14, Level = Models.Enums.Level.pleno, Position = "Desenvolvedor Python",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor12 = new Mentor
            {
                Name = "Raquel Siqueira", Email = "raqsiqe@hotmail.com", Expertise = expertise9, Level = Models.Enums.Level.senior, Position = "Desenvolvedora Front-end",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor13 = new Mentor
            {
                Name = "Maria Cláudia P.", Email = "cacauup@hotmail.com", Expertise = expertise8, Level = Models.Enums.Level.junior, Position = "Desenvolvedora Java",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor14 = new Mentor
            {
                Name = "Alexandre Brito", Email = "alexbr@hotmail.com", Expertise = expertise7, Level = Models.Enums.Level.pleno, Position = "Desenvolvedor Front-end",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor15 = new Mentor
            {
                Name = "Daniel Pereira", Email = "danpere@hotmail.com", Expertise = expertise15, Level = Models.Enums.Level.master, Position = "UX Writer",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor16 = new Mentor
            {
                Name = "Joaquina Barros", Email = "jobarro@hotmail.com", Expertise = expertise10, Level = Models.Enums.Level.pleno, Position = "Desenvolvedora mobile",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor17 = new Mentor
            {
                Name = "Eduardo Borges", Email = "eduborg@hotmail.com", Expertise = expertise2, Level = Models.Enums.Level.pleno, Position = "Desenvolvedor C#",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor18 = new Mentor
            {
                Name = "Eric Campos", Email = "ericcam@hotmail.com", Expertise = expertise7, Level = Models.Enums.Level.pleno, Position = "Desenvolvedor Front-end",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

            Mentor mentor19 = new Mentor
            {
                Name = "Mariana Castro", Email = "mcastro@hotmail.com", Expertise = expertise10, Level = Models.Enums.Level.pleno, Position = "Desenvolvedora Mobile",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

             Mentor mentor20 = new Mentor
             {
                Name = "Carol Freitas", Email = "cfreita@hotmail.com", Expertise = expertise1, Level = Models.Enums.Level.pleno, Position = "Desenvolvedora C++",
                 Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

             Mentor mentor21 = new Mentor
             {
                Name = "Gabriel Gomes", Email = "ggomess@hotmail.com", Expertise = expertise4, Level = Models.Enums.Level.pleno, Position = "Desenvolvedor DevOps",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };

             Mentor mentor22 = new Mentor
             {
                Name = "Bruna Martins", Email = "brunamt@hotmail.com", Expertise = expertise, Level = Models.Enums.Level.pleno, Position = "Desenvolvedora Back-end",
                Day = 16, Day1 = 17, Day2 = 18, Day3 = 19, Day4 = 20, Day5 = 21, Day6 = 22, Slot = "14:00h", Slot1 = "15:00h", Slot2 = "14:30", Slot4 = "16:00h", Slot5 = "17:30", Slot6 = "13:00h", Slot8 = "14:00h", Slot9 = "16:00", Slot10 = "17:00h", Slot11 = "17:30h", Slot12 = "15:30h", Slot13 = "16:00",
                Password = "123456", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac turpis et ex bibendum ultrices id at lacus. Cras sit amet imperdiet magna, faucibus venenatis libero. Morbi at tortor tellus."
            };



            _context.Expertise.AddRange(expertise, expertise1, expertise2, expertise3, expertise4, expertise5, expertise6, expertise7, expertise8,
                expertise9, expertise10, expertise11, expertise12, expertise13, expertise14, expertise15);
            _context.Mentor.AddRange(mentor, mentor1, mentor2, mentor3, mentor4, mentor5, mentor6, mentor7, mentor8, mentor9, mentor10, mentor11, mentor12, mentor13, mentor14, mentor15, mentor16,
                mentor17, mentor18, mentor19, mentor20, mentor21, mentor22);
            _context.SaveChanges();
        }

    }
}
