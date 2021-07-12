using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Impl {
    public class ScheduleValidate {
        public University University { get; set; }

        public bool IsValidated {get; set;}
        public string LogFile { get; set; }

        StringBuilder _stringBuilder = new StringBuilder();

        public ScheduleValidate(University university, string logFile) {
            University = university;
            IsValidated = false;
            LogFile = logFile;
        }
        public bool ValidateNewSchedule(Schedule newSchedule) {
            Course course = University.Courses.Find(x => x.Id == newSchedule.CourseId);
            Professor professor = University.Professors.Find(x => x.Id == newSchedule.ProfessorId);
            Student student = University.Students.Find(x => x.Id == newSchedule.StudentId);

            //TODO1: Course category matches student validcourses
            CourseCategoryValidForStudent(student, course);

            //TODO2: Course category matches professor validcourses
            CourseCategoryValidForProfessor(professor, course);

            //TODO3: Schedule is not duplicate in schedule list
            CheckScheduleDuplicity(newSchedule);


            //TODO4: Schedule complies with preferences
            //TODO5: Schedule for student cannot be in same time no matter what
            CheckStudentTimeAvailability();
            //TODO6: Schedule for professor can only be in same time if student is different and course is same

            File.AppendAllText(LogFile, _stringBuilder.ToString());
            _stringBuilder.Clear();
            return false;
        }

        private bool CourseCategoryValidForStudent(Student student, Course course) {
            try {
                return student.ValidCourseCategories.Exists(x => x == course.Category);
            }
            catch (Exception e) {
                _stringBuilder.Append(e.Message);
            }
            return false;
        }

        private bool CourseCategoryValidForProfessor(Professor professor, Course course) {
            try {
                return professor.ValidCourseCategories.Exists(x => x == course.Category);
            }
            catch (Exception e) {
                _stringBuilder.Append(e.Message);
            }
            return false;
        }

        private bool CheckScheduleDuplicity(Schedule newSchedule) {
            try {
                if (!University.ScheduleList.Exists(x => x.Id == newSchedule.Id)) {
                    return false;
                }

                foreach (var schedule in University.ScheduleList.FindAll(x => x.ProfessorId == newSchedule.ProfessorId)) {
                    if (schedule.CourseId == newSchedule.CourseId && schedule.StudentId == newSchedule.StudentId && schedule.Calendar == newSchedule.Calendar) {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception e) {
                _stringBuilder.Append(e.Message);
            }
            return false;
        }

        private bool CheckStudentTimeAvailability(Student student, Schedule newSchedule) {
            try {
                return !University.ScheduleList.Exists(x => x.Calendar == newSchedule.Calendar);
            }
            catch (Exception e) {
                _stringBuilder.Append(e.Message);
            }
            return false;

        }
    }
}
