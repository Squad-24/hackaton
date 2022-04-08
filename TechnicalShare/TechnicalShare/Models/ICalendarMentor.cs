using System;

namespace TechnicalShare.Models
{
    public interface ICalendarMentor
    {
        DateTime dateTimeMentor { get; set; }
        Mentor Mentor { get; set; }
        int MentorId { get; set; }
    }
}