using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models
{
    public class Expertise : IExpertise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Expertise()
        {
                
        }

        public Expertise(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Expertise(string name)
        {
            Name = name;
        }

        
    }
}
