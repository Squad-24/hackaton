using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models
{
    public class Mentee : IMentee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<MentorMentee> Mentors { get; set; } = new List<MentorMentee>();
        public Mentee()
        {

        }

        public Mentee(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
           
        }

        public Mentee(string name, string email)
        {           
            Name = name;
            Email = email;

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
