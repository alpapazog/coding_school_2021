using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Impl {
    public class SchedulePreferences {
        public short MaxCoursesPerStudentPerDay { get; set; } = 3;
        public short MaxCoursesPerStudentPerWeek { get; set; } = 50;
        public short MaxProfessorCoursesPerWeek { get; set; } = 40;
        public short MaxProfessorCoursesPerDay { get; set; } = 4;

        public SchedulePreferences() {
            MaxCoursesPerStudentPerDay = 3;
            MaxCoursesPerStudentPerWeek = 50;
            MaxProfessorCoursesPerWeek = 40;
            MaxProfessorCoursesPerDay = 4;
        }
    }
}
