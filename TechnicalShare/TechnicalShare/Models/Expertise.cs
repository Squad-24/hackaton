using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models
{
    public class Expertise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Mentor> Mentors { get; set; } = new List<Mentor>();
        public Expertise()
        {
                
        }

        public Expertise(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }
    }
}
