using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EducationOn.Model;

namespace EducationOn.Data
{
    public class EducationOnContext : DbContext
    {
        public EducationOnContext (DbContextOptions<EducationOnContext> options)
            : base(options)
        {
        }

        public DbSet<EducationOn.Model.Lecture> Lecture { get; set; } = default!;

        public DbSet<EducationOn.Model.Studentdashboard>? Studentdashboard { get; set; }
    }
}
