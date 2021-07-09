using System;
using System.Collections.Generic;

namespace UniversityApp.Impl {
    public class Professor {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Age { get; set; }
        public string Rank { get; set; }
        public List<CoursesCategoryEnum> CAN_TEACH { get; set; }

        public Professor() {
            ID = Guid.NewGuid();
        }
    }

}

