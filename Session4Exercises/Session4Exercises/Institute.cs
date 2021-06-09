using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercises {
    class Institute {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }


        public Institute() {
            ID = Guid.NewGuid();
        }
        public String GetName() {
            return Name;
        }

        public void SetName(string s) {
            Name = s;
        }
    }

    class University : Institute {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduledCourse { get; set; }


        public University() {
            
        }

        public Student[] GetStudents() {
            return Students;
        }

        public Course[] GetCourses() {
            return Courses;
        }

        public Grade[] GetGrades() {
            return Grades;
        }

        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime) {

        }
    }
}
