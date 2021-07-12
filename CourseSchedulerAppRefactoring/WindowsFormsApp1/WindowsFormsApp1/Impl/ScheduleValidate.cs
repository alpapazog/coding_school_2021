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

            bool val1 = CourseCategoryValidForStudent(student, course);

            bool val2 = CourseCategoryValidForProfessor(professor, course);

            bool val3 = CheckScheduleDuplicity(newSchedule);

            bool val4 = CheckStudentTimeAvailability(newSchedule);

            bool val5 = CheckProfessorAvailability(newSchedule);

            bool val6 = CheckPreferenceProfessorMaxCoursesPerDay(newSchedule);

            IsValidated = val1 && val2 && val3 && val4 && val5 && val6;

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
                _stringBuilder.Append(e.ToString());
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
                _stringBuilder.Append(e.ToString());
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
                _stringBuilder.Append(e.ToString());
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
                _stringBuilder.Append(e.ToString());
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
                _stringBuilder.Append(e.ToString());
            }
            return false;
        }

        public bool CheckPreferenceProfessorMaxCoursesPerDay(Schedule newSchedule) {
            int coursesPerDay = University.ScheduleList.FindAll(x => x.Calendar.Date == newSchedule.Calendar.Date && x.ProfessorId == newSchedule.ProfessorId).Count;
            if (coursesPerDay+1 <= University.Preferences.MaxProfessorCoursesPerDay) {
                return true;
            }
            else {
                ErrorMessage = string.Concat(ErrorMessage, "\n", string.Format("Professors cannot have more than {0} courses per day.", University.Preferences.MaxProfessorCoursesPerDay));
                return false;
            }
        }

    }
}
