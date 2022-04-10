using System;

namespace TechnicalShare.Models
{
    public interface ICalendarMentor
    {
        int Id { get; set; }
        DateTime dateTimeMentor { get; set; }
        Mentor Mentor { get; set; }
        int MentorId { get; set; }
        DateTime Start { get; set; }
        DateTime Finish { get; set; }
    }
}