using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Impl {

    public class University  {

        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }
        public List<Schedule> ScheduleList { get; set; }

        public University() {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            ScheduleList = new List<Schedule>();
        }

        public void run_once() {


            // TODO: MUST IMPLEMENT ENUMERATION FOR CATEGORY ?

            Courses.Add( new Course() {
                 
                Code = "1",
                Subject = "Quantum Physics",
                Category = 0, // physics
                Hours = 100
            });

            Courses.Add(new Course() {
                
                Code = "2",
                Subject = "Electo-Dynamics",
                Category = 0, // physics ?
                Hours = 50
            });

            Courses.Add(new Course() {
                
                Code = "3",
                Subject = "Basic Chemistry",
                Category = 1, // Chemistry
                Hours = 50
            });

            Courses.Add(new Course() {
                
                Code = "04",
                Subject = "Financial II",
                Category = 2, // Financial
                Hours = 50
            });

            Courses.Add(new Course() {
                
                Code = "5",
                Subject = "Mathematics I",
                Category = 3, // Mathematics
                Hours = 50
            });

            Students.Add(new Student() {
                Id = Guid.NewGuid(),
                Name = "Fotis",
                Surname = "Chrysoulas",
                Registration_Number = "1234",
                CAN_LEARN = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Chemistry, CoursesCategoryEnum.Financial }
            });


            Students.Add(new Student() {
                Id = Guid.NewGuid(),
                Name = "Dimitris",
                Surname = "Raptodimos",
                Registration_Number = "1235",
                CAN_LEARN = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Financial } 
            });

            Professors.Add(new Professor() {
                Name = "Maria",
                Surname = "Papadopoulou",
                Rank = "1"
            });


        }

    }

}

