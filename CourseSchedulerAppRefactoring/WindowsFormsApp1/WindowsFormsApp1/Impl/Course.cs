using UniversityApp.Base;

namespace UniversityApp.Impl {
    public class Course : Entity {
        public string Code { get; set; }
        public string Subject { get; set; }
        public int Hours { get; set; }
        public int Category { get; set; }

        public Course() : base() {
                
        }

    }

}

