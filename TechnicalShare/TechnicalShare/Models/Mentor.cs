using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechnicalShare.Models.Enums;

namespace TechnicalShare.Models
{
    public class Mentor : IMentor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "*")]
        public string Position { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(220, ErrorMessage = "máximo de 220 caracteres")]
        public string Description { get; set; }
                
        [Required(ErrorMessage = "*")]
        public Level Level { get; set; }

        [Required(ErrorMessage = "*")]
        public Expertise Expertise { get; set; }

        [Required(ErrorMessage = "*")]
        public int ExpertiseId { get; set; }       
        public string ExpertiseName { get; set; }
        public int Day { get; set; }
        public int Day1 { get; set; }
        public int Day2 { get; set; }
        public int Day3 { get; set; }
        public int Day4 { get; set; }
        public int Day5 { get; set; }
        public int Day6 { get; set; }
        public string Slot { get; set; }
        public string Slot1 { get; set; }
        public string Slot2 { get; set; }
        public string Slot3 { get; set; }
        public string Slot4 { get; set; }
        public string Slot5 { get; set; }
        public string Slot6 { get; set; }
        public string Slot7 { get; set; }
        public string Slot8 { get; set; }
        public string Slot9 { get; set; }
        public string Slot10 { get; set; }
        public string Slot11 { get; set; }
        public string Slot12 { get; set; }
        public string Slot13 { get; set; }
        public DateTime Schedule { get; set; }

        public ICollection<MentorMentee> Mentees { get; set; } = new List<MentorMentee>();
   /*
        public Mentor()
        {

        }

        public Mentor(int id, string name, string email, string password, string position, Level level, Expertise expertise) 
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Position = position;
            Level = level;
            Expertise = expertise;
        }

        public Mentor(string name, string email, string password, string position, Level level, Expertise expertise)
        {            
            Name = name;
            Email = email;
            Password = password;
            Position = position;
            Level = level;
            Expertise = expertise;
        }
                
        public void AddMentee(MentorMentee mentee)
        {
            Mentees.Add(mentee);
        }

        public void RemoveMentee(MentorMentee mentee)
        {
            Mentees.Remove(mentee);
        }
   */
       
    }
}
