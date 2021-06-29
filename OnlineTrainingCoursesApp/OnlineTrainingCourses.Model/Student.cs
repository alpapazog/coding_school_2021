using System;

namespace OnlineTrainingCourses.Model {
    public class Student : Entity{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        
    }
}
