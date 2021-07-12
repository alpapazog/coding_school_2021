using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Impl {
    public class ScheduleValidate {
        public University University { get; set; }

        public string ErrorMessage { get; set; }
        public bool IsValidated {get; set;}
        public string LogFile { get; set; }

        StringBuilder _stringBuilder = new StringBuilder();

        public ScheduleValidate(University university, string logFile) {
            University = university;
            IsValidated = false;
            LogFile = logFile;
        }
        public bool ValidateNewSchedule(Schedule newSchedule) {
            IsValidated = true;
            Course course = University.Courses.Find(x => x.Id == newSchedule.CourseId);
            Professor professor = University.Professors.Find(x => x.Id == newSchedule.ProfessorId);
            Student student = University.Students.Find(x => x.Id == newSchedule.StudentId);

            //TODO1: Course category matches student validcourses
            IsValidated = (IsValidated && CourseCategoryValidForStudent(student, course));

            //TODO2: Course category matches professor validcourses
            IsValidated = (IsValidated && CourseCategoryValidForProfessor(professor, course));

            //TODO3: Schedule is not duplicate in schedule list
            IsValidated = (IsValidated && CheckScheduleDuplicity(newSchedule));


            //TODO4: Schedule complies with preferences
            //TODO5: Schedule for student cannot be in same time no matter what
            IsValidated = (IsValidated && CheckStudentTimeAvailability(newSchedule));

            //TODO6: Schedule for professor can only be in same time if student is different and course is same
            IsValidated = (IsValidated && CheckProfessorAvailability(newSchedule));

            File.AppendAllText(LogFile, _stringBuilder.ToString());
            _stringBuilder.Clear();
            return IsValidated;
        }

        public bool CourseCategoryValidForStudent(Student student, Course course) {
            try {
                if (student.ValidCourseCategories.Exists(x => x == course.Category)) {
                    return true;
                }
                else {
                    ErrorMessage = string.Concat(ErrorMessage, "\n", "Student is not eligible for the selected course category.");
                    return false;
                }
            }
            catch (Exception e) {
                ErrorMessage = "Exception thrown, check Log.txt for details";
                _stringBuilder.Append(e.Message);
            }
            return false;
        }

        public bool CourseCategoryValidForProfessor(Professor professor, Course course) {
            try {
                if (professor.ValidCourseCategories.Exists(x => x == course.Category)) {
                    return true;
                }
                else {
                    ErrorMessage = string.Concat(ErrorMessage, "\n", "Professor is not eligible for the selected course category.");
                    return false;
                }
            }
            catch (Exception e) {
                ErrorMessage = "Exception thrown, check Log.txt for details";
                _stringBuilder.Append(e.Message);
            }
            return false;
        }

        public bool CheckScheduleDuplicity(Schedule newSchedule) {
            try {
                if (University.ScheduleList.Exists(x => x.Id == newSchedule.Id)) {
                    ErrorMessage = string.Concat(ErrorMessage, "\n", "Schedule already exists");
                    return false;
                }

                foreach (var schedule in University.ScheduleList.FindAll(x => x.ProfessorId == newSchedule.ProfessorId)) {
                    if (schedule.CourseId == newSchedule.CourseId && schedule.StudentId == newSchedule.StudentId && schedule.Calendar == newSchedule.Calendar) {
                        ErrorMessage = string.Concat(ErrorMessage, "\n", "Schedule already exists");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception e) {
                ErrorMessage = "Exception thrown, check Log.txt for details.";
                _stringBuilder.Append(e.Message);
            }
            return false;
        }

        public bool CheckStudentTimeAvailability(Schedule newSchedule) {
            try {
                if (University.ScheduleList.Exists(x => x.Calendar == newSchedule.Calendar && x.StudentId == newSchedule.StudentId)) {
                    ErrorMessage = string.Concat(ErrorMessage,"\n","Student is not available during that time");
                    return false;
                }
                else {
                    return true;
                }
            }
            catch (Exception e) {
                ErrorMessage = "Exception thrown, check Log.txt for details";
                _stringBuilder.Append(e.Message);
            }
            return false;
        }

        public bool CheckProfessorAvailability(Schedule newSchedule) {
            try {
                foreach (Schedule schedule in University.ScheduleList.FindAll(x => x.ProfessorId == newSchedule.ProfessorId && x.Calendar == newSchedule.Calendar)) {
                    if (schedule.CourseId != newSchedule.CourseId) {
                        ErrorMessage = string.Concat(ErrorMessage, "\n", "Professor is not available during that time");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception e) {
                ErrorMessage = "Exception thrown, check Log.txt for details";
                _stringBuilder.Append(e.Message);
            }
            return false;
        }
    }
}
