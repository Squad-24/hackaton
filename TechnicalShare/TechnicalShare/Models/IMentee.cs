using System.Collections.Generic;

namespace TechnicalShare.Models
{
    public interface IMentee
    {
        string Email { get; set; }
        int Id { get; set; }
        ICollection<MentorMentee> Mentors { get; set; }
        string Name { get; set; }

        void AddMentor(MentorMentee mentor);
        void RemoveMentor(MentorMentee mentor);
    }
}