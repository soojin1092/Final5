using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Soojin_College_Strike.Models
{
    public class Member
    {
        public Member()
        {
            Shifts = new HashSet<Shift>();
            Member_Position = new HashSet<Member_Position>();
        }
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You cannot leave the first name blank.")]
        [StringLength(50, ErrorMessage = "First name is too long dummy!!!!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You cannot leave the last name blank.")]
        [StringLength(50, ErrorMessage = "Last name cannot be more than 100 characters long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression("^\\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number (no spaces).")]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:(###) ###-####}", ApplyFormatInEditMode = false)]
        public Int64 Phone { get; set; }

        [Required(ErrorMessage = "Email Address is required.")]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string eMail { get; set; }

        [Display(Name = "Assignment")]
        [Required(ErrorMessage = "Assignment is required.")]
        public int AssignmentID { get; set; }
        public Assignment Assignment { get; set; }

        public ICollection<Shift> Shifts { get; set; }
        public ICollection<Member_Position> Member_Position { get; set; }
    }
}
