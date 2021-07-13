using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Impl {
    public class SchedulePreferences {
        public short MaxStudentCoursesPerDay { get; set; }
        public short MaxStudentCoursesPerWeek { get; set; }
        public short MaxProfessorCoursesPerWeek { get; set; }
        public short MaxProfessorCoursesPerDay { get; set; }

        public SchedulePreferences() {
            MaxStudentCoursesPerDay = 3;
            MaxStudentCoursesPerWeek = 5;
            MaxProfessorCoursesPerWeek = 5;
            MaxProfessorCoursesPerDay = 4;
        }
    }
}
