using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentService
{
    [DataContract]
    public class Student
    {
        [DataMember]
        [Key()]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        [ForeignKey("Course")]
        public int courseID { get; set; }

        [DataMember]
        [ForeignKey("Gender")]
        public int genderID { get; set; }

        [DataMember]
        public virtual Gender Gender { get; set; }

        [DataMember]
        public virtual Course Course { get; set; }

        public Student Save()
        {
            var db = new BaseContext();
            db.Students.Add(this);
            db.SaveChanges();
            return this;
        }

        public static List<Student> List()
        {
				using (var context = new BaseContext())
				{

					var query = (from a in context.Students select a).Distinct();

					List<Student> students = new List<Student>();

					query.ToList().ForEach(student =>
					{
						students.Add(new Student{
							Course = student.Course,
							courseID = student.courseID,
							Gender = student.Gender,
							genderID = student.genderID,
							id = student.id,
							name = student.name
						});
					});
					return students;
				}
			}

        public static void Update(Student _student)
        {
            using (var context = new BaseContext())  {
                
                var query = context.Students.Where(n => n.id == _student.id);

                var student = query.FirstOrDefault();

                student.name = _student.name;
                student.courseID = _student.courseID;
                student.genderID = _student.genderID;

                context.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (var context = new BaseContext())
            {

                var query = context.Students.Where(n => n.id == id);

                var student = query.FirstOrDefault();

                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }
}