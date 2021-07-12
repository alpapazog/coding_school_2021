using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UniversityApp.Impl;

namespace Tests {
    [TestClass]
    public class ValidateScheduleTests {
        University university = new University();
        public void Init() {
            Student student = new Student() {
                ValidCourseCategories = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Physics }
            };

            Professor professor = new Professor() {
                ValidCourseCategories = new List<CourseCategoryEnum>() { CourseCategoryEnum.Mathematics, CourseCategoryEnum.Financial }
            };

            Course course = new Course() {
                Category = CourseCategoryEnum.Physics
            };

            university.Courses.Add(course);
            university.Students.Add(student);
            university.Professors.Add(professor);
        }
        [TestMethod]
        public void ValidateScheduleTest_InputDuplicateSchedule_ReturnsFalse() {
            Init();
            Schedule firstSchedule = new Schedule() {
                CourseId = university.Courses[0].Id,
                ProfessorId = university.Professors[0].Id,
                StudentId = university.Students[0].Id,
                Calendar = DateTime.Now
            };

            university.ScheduleList.Add(firstSchedule);
            Schedule newSchedule = new Schedule() {
                CourseId = firstSchedule.CourseId,
                ProfessorId = firstSchedule.ProfessorId,
                StudentId = firstSchedule.StudentId,
                Calendar = firstSchedule.Calendar
            };
            Assert.IsFalse(university.ValidateNewSchedule(newSchedule));
        }
    }
}
