using System;

namespace OnlineTrainingCourses.Model {
    public class Course : Entity{
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }

    }
}
