using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models
{
    public class Mentee : User
    {
        public ICollection<MentorMentee> Mentors { get; set; } = new List<MentorMentee>();
        public Mentee()
        {

        }

        public Mentee(int id, string name, string email, string password, Expertise expertise)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Expertise = expertise;
        }

        public void AddMentor(MentorMentee mentor)
        {
            Mentors.Add(mentor);
        }

        public void RemoveMentor(MentorMentee mentor)
        {
            Mentors.Remove(mentor);
        }
    }
}
