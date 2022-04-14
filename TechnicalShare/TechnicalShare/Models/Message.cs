using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalShare.Models
{
    public class Message
    {
        public Int64 destination { get; set; }
        public User sender { get; set; }
        public string message { get; set; }
    }
}
