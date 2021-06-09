using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercises {
    class Person {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Person() {
            ID = Guid.NewGuid();
        }

        public String GetName() {
            return Name;
        }

        public void SetName(string s) {
            Name = s;
        }
    }

    class Professor : Person {
        public string Rank { get; set; }
        public Course[] Courses { get; set; }

        public void Teach(Course course, DateTime datetime) {

        }

        public void SetGrade(Guid studentID, Guid courseID, Grade grade) {

        }
        
        // GetName() is called from parent class automatically
    }

    class Student : Person {
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        public void Attend(Course course, DateTime datetime) {

        }

        public void WriteExam(Course course, DateTime datetime) {

        }

    }
}
