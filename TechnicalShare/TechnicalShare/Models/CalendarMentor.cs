using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models
{
    public class CalendarMentor : ICalendarMentor
    {
        public int Id { get; set; }
        public DateTime dateTimeMentor { get; set; }

        public int MentorId { get; set; }

        public Mentor Mentor { get; set; }

        public DateTime Start { get; set; }
        public DateTime Finish {get;set; }
    }
}
