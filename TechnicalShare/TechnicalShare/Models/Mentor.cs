using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechnicalShare.Models.Enums;

namespace TechnicalShare.Models
{
    public class Mentor : IMentor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        public string Position { get; set; }
        [Required(ErrorMessage = "*")]
        public Level Level { get; set; }
        [Required(ErrorMessage = "*")]
        public Expertise Expertise { get; set; }
        [Required(ErrorMessage = "*")]
        public int ExpertiseId { get; set; }       
        public string ExpertiseName { get; set; }
       
        public ICollection<MentorMentee> Mentees { get; set; } = new List<MentorMentee>();
        public Mentor()
        {

        }

        public Mentor(int id, string name, string email, string password, string position, Level level, Expertise expertise) 
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Position = position;
            Level = level;
            Expertise = expertise;
        }

        public Mentor(string name, string email, string password, string position, Level level, Expertise expertise)
        {            
            Name = name;
            Email = email;
            Password = password;
            Position = position;
            Level = level;
            Expertise = expertise;
        }
                
        public void AddMentee(MentorMentee mentee)
        {
            Mentees.Add(mentee);
        }

        public void RemoveMentee(MentorMentee mentee)
        {
            Mentees.Remove(mentee);
        }

       
    }
}
