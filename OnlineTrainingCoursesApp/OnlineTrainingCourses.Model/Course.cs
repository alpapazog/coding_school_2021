using System;
using System.Collections.Generic;

namespace OnlineTrainingCourses.Model {
    public class Course : Entity{
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public Course() {
            this.Students = new HashSet<Student>();

        }

    }
}
