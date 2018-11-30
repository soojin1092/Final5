using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Soojin_College_Strike.Models
{
    public class Shift
    {        
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ShiftDate { get; set; }

        [Display(Name = "Member")]
        [Required(ErrorMessage = "Member is required.")]
        public int MemberID { get; set; }
        public Assignment Member { get; set; }

        [Display(Name = "Assignment")]
        [Required(ErrorMessage = "Assignment is required.")]
        public int AssignmentID { get; set; }
        public Assignment Assignment { get; set; }

    }
}
