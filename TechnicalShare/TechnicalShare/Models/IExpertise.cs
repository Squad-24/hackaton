using System.Collections.Generic;

namespace TechnicalShare.Models
{
    public interface IExpertise
    {
        int Id { get; set; }
        string Name { get; set; }
        public ICollecion<Mentor> Mentors { get; set; }
        void AddMentor(Mentor mentor);
    }
}