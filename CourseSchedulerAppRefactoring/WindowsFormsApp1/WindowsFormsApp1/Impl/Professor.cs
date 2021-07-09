using System;
using System.Collections.Generic;
using UniversityApp.Base;

namespace UniversityApp.Impl {
    public class Professor : Person {
        public string Rank { get; set; }
        public List<CoursesCategoryEnum> CAN_TEACH { get; set; }

        public Professor() : base() {
        }
    }

}

