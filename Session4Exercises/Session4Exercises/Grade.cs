using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercises {
    class Grade {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeScore { get; set; }

        public Grade() {
            ID = Guid.NewGuid();
        }
    }
}
