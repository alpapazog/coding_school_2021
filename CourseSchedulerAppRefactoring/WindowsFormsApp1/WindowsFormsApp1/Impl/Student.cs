using System;
using System.Collections.Generic;
using UniversityApp.Base;

namespace UniversityApp.Impl {
    public class Student : Person {
        public string Registration_Number { get; set; }
        public List<CourseCategoryEnum> CAN_LEARN { get; set; }
        public Student() : base() {

        }
    }

}

