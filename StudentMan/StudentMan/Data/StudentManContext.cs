using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMan.Model;

namespace StudentMan.Data
{
    public class StudentManContext : DbContext
    {
        public StudentManContext (DbContextOptions<StudentManContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMan.Model.Course> Course { get; set; } = default!;

        public DbSet<StudentMan.Model.Student>? Student { get; set; }
    }
}
