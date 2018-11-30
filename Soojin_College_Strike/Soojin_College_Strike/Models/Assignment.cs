using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Soojin_College_Strike.Models
{
    public class Assignment
    {
        public Assignment()
        {
            Shifts = new HashSet<Shift>();
            Members = new HashSet<Member>();

        }
        public int ID { get; set; }

        [Display(Name = "Assignment Name")]
        [Range(5, 200, ErrorMessage = "Assignment Name must be between 5 and 200")]
        [Required(ErrorMessage = "You cannot leave the Assignment Name blank.")]
        public string AssignmentName { get; set; }

        public ICollection<Shift> Shifts { get; set; }
        public ICollection<Member> Members { get; set; }

    }
}
