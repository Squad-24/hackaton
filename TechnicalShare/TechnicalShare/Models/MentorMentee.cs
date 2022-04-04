﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models
{
    public class MentorMentee
    {
        [Key]
        public int MentorId { get; set; }
        public Mentor Mentor { get; set; }

        public int MenteeId { get; set; }
        public Mentee Mentee { get; set; }

        public MentorMentee()
        {

        }
        public MentorMentee(int mentorId, Mentor mentor, int menteeId, Mentee mentee)
        {
            MentorId = mentorId;
            Mentor = mentor;
            MenteeId = menteeId;
            Mentee = mentee;
        }

        public MentorMentee(int mentorId, Mentor mentor)
        {
            MentorId = mentorId;
            Mentor = mentor;
        }

        public MentorMentee(int menteeId, Mentee mentee)
        {
            MenteeId = menteeId;
            Mentee = mentee;
        }
    }
}
