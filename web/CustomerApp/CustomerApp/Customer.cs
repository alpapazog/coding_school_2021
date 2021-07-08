using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApp {
    public class Customer {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [StringLength(9)]
        public string AFM { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "The field Is Active must be checked.")]
        public bool? Active { get; set; }

        public Customer(int? id, string name, string surname, string afm, bool? active) {
            Id = id;
            Name = name;
            Surname = surname;
            AFM = afm;
            Active = active;
        }
    }
}
