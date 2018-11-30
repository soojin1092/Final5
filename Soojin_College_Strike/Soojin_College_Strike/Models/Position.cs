using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Soojin_College_Strike.Models
{
    public class Position
    {
        public Position()
        {
            Member_Position = new HashSet<Member_Position>();
        }
        public int ID { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "You cannot leave the title blank.")]
        [StringLength(50, ErrorMessage = "Title is too long dummy!!!!")]
        public string Title { get; set; }

        public ICollection<Member_Position> Member_Position { get; set; }

    }
}
