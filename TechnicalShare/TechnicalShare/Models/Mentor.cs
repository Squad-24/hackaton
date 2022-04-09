using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Models.Enums;

namespace TechnicalShare.Models
{
    public class Mentor : IMentor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public Level Level { get; set; }

        public Expertise Expertise { get; set; }

        public int ExpertiseId { get; set; }       
        public string ExpertiseName { get; set; }
       
        public ICollection<MentorMentee> Mentees { get; set; } = new List<MentorMentee>();
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

       
    }
}
