using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentService
{
    public class Gender
    {
        [Key()]
        public int id { get; set; }
        public string label { get; set; }

        public static List<Gender> List()
        {
            var db = new BaseContext();
            return db.Genders.ToList();
        }
    }
}