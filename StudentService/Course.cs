using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentService
{
	[DataContract]
    public class Course
    {
		  [DataMember]
        [Key()]
        public int id { get; set; }
		  [DataMember]
        public string label { get; set; }

        public static List<Course> List()
        {
            var db = new BaseContext();
            return db.Courses.ToList();
        }
    }
}