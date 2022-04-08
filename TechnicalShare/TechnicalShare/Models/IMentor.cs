﻿using System.Collections.Generic;
using TechnicalShare.Models.Enums;

namespace TechnicalShare.Models
{
    public interface IMentor
    {
        string Email { get; set; }
        Expertise Expertise { get; set; }
        int ExpertiseId { get; set; }
        string ExpertiseName { get; set; }
        int Id { get; set; }
        Level Level { get; set; }
        ICollection<MentorMentee> Mentees { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Position { get; set; }

        void AddMentee(MentorMentee mentee);
        void RemoveMentee(MentorMentee mentee);
    }
}