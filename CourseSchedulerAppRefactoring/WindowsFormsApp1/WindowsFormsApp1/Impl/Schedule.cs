using System;
using UniversityApp.Base;

namespace UniversityApp.Impl {
    public class Schedule : Entity {
        public Guid StudentId { get; set; }
        public Guid ProfessorId { get; set; }
        public Guid CourseId { get; set; }
        public DateTime Calendar { get; set; }
        public Schedule() : base() {

        }
    }

}