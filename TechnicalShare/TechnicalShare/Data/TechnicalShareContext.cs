using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Models;

namespace TechnicalShare.Data
{
    public class TechnicalShareContext : DbContext
    {
        public TechnicalShareContext(DbContextOptions<TechnicalShareContext> options) : base(options)
        {
        }

        public DbSet<Expertise> Expertise { get; set; }
        public DbSet<Mentee> Mentee { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<MentorMentee> MentorMentee { get; set; }
    }
}
