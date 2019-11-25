using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentService
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("school") {}
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }
}