using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Impl {
    public class SchedulePreferences {
        public short MaxCoursesPerStudentPerDay { get; set; } = 3;
        public short MinCoursesPerStudentPerWeek { get; set; } = 0;
        public short MinProfessorCoursesPerWeek { get; set; } = 0;
        public short MaxProfessorCoursesPerWeek { get; set; } = 40;
        public short MinProfessorCoursesPerDay { get; set; } = 0;
        public short MaxProfessorCoursesPerDay { get; set; } = 4;
    }
}
