using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Data;

namespace TechnicalShare.Services
{
    public class ExpertiseService
    {
        private readonly TechnicalShareContext _context;

        public ExpertiseService(TechnicalShareContext context)
        {
            _context = context;
        }
    }
}
