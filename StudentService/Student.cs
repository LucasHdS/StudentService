using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentService
{
    public class Student
    {
        [Key()]
        public int id { get; set; }
        public string name { get; set; }
        public int tel { get; set; }
        public int cpf { get; set; }

        [ForeignKey("Course")]
        public int courseID { get; set; }
        
        [ForeignKey("Gender")]
        public int genderID { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Course Course { get; set; }

        public void Save()
        {
            var db = new BaseContext();
            db.Students.Add(this);
            db.SaveChanges();
        }

        public static List<Student> List()
        {
            var db = new BaseContext();
            return db.Students.ToList();
        }

        public static void Alter()
        {
               
        }
    }
}