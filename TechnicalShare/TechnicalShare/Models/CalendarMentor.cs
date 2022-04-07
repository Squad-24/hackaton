using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models
{
    public class CalendarMentor
    {
        public DateTime dateTimeMentor { get; set; }
        
        public int MentorId { get; set; }

        public Mentor Mentor { get; set; }
    }
}
