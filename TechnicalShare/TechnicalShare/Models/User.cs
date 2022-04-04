using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Expertise Expertise { get; set; }

        public User()
        {
                
        }

        public User(int id, string name, string email, string password, Expertise expertise)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Expertise = expertise;
        }
    }
}
