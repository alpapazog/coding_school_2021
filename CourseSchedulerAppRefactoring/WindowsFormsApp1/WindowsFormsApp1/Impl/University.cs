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

        public SchedulePreferences Preferences;
        public University() {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            ScheduleList = new List<Schedule>();
            Preferences = new SchedulePreferences();
        }

        public void InitUniversity() {
            Courses.Add( new Course() {
                 
                Code = "1",
                Subject = "Quantum Physics",
                Category = CourseCategoryEnum.Physics,
                Hours = 100
            });

            Courses.Add(new Course() {
                
                Code = "2",
                Subject = "Electo-Dynamics",
                Category = CourseCategoryEnum.Physics,
                Hours = 50
            });

            Courses.Add(new Course() {
                
                Code = "3",
                Subject = "Basic Chemistry",
                Category = CourseCategoryEnum.Chemistry,
                Hours = 50
            });

            Courses.Add(new Course() {
                
                Code = "4",
                Subject = "Financial II",
                Category = CourseCategoryEnum.Financial,
                Hours = 50
            });

            Courses.Add(new Course() {
                
                Code = "5",
                Subject = "Mathematics I",
                Category = CourseCategoryEnum.Mathematics,
                Hours = 50
            });

            Students.Add(new Student() {
                Name = "Fotis",
                Surname = "Chrysoulas",
                Registration_Number = "1234",
                ValidCourseCategories = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });

            Students.Add(new Student() {
                Name = "Dimitris",
                Surname = "Raptodimos",
                Registration_Number = "1235",
                ValidCourseCategories = new List<CourseCategoryEnum>() { CourseCategoryEnum.Physics, CourseCategoryEnum.Financial } 
            });

            Students.Add(new Student() {
                Name = "Alexis",
                Surname = "Papazoglou",
                Registration_Number = "1900",
                ValidCourseCategories = new List<CourseCategoryEnum>() { CourseCategoryEnum.Mathematics, CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor() {
                Name = "Maria",
                Surname = "Papadopoulou",
                Rank = "Assistant",
                ValidCourseCategories = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor() {
                Name = "John",
                Surname = "Doe",
                Rank = "Associate",
                ValidCourseCategories = new List<CourseCategoryEnum>() { CourseCategoryEnum.Mathematics, CourseCategoryEnum.Physics }
            });


        }
        

    }

}