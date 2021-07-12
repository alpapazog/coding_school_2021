using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Impl;

namespace UniversityApp.Base {
    public class Person : Entity {
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Age { get; set; }
        public List<CourseCategoryEnum> ValidCourseCategories { get; set; }
        public Person() : base() {

        }
    }
}
