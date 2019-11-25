using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentService
{
    public class Course
    {
        [Key()]
        public int id { get; set; }
        public string label { get; set; }

        public static List<Course> List()
        {
            var db = new BaseContext();
            return db.Courses.ToList();
        }
    }
}