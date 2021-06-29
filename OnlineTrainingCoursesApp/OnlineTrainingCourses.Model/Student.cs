using System;
using System.Collections.Generic;

namespace OnlineTrainingCourses.Model {
    public class Student : Entity{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public Student() {
            this.Courses = new HashSet<Course>();
        }

    }
}
