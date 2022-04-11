using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models.ViewModels
{
    public class MentorFormViewModel
    {
        public Mentor Mentor { get; set; }
        public ICollection<Expertise> Expertises { get; set; }
    }
}
