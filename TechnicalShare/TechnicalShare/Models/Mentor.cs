using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Models.Enums;

namespace TechnicalShare.Models
{
    public class Mentor : User
    {
        public Level Level { get; set; }
        public ICollection<MentorMentee> Mentees { get; set; } = new List<MentorMentee>();
        public Mentor()
        {

        }

        public Mentor(int id, string name, string email, string password, Expertise expertise, Level level)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Expertise = expertise;
            Level = level;
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
