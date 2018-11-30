using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soojin_College_Strike.Models
{
    public class Member_Position
    {
        public int MemberID { get; set; }
        public Member Member { get; set; }

        public int PositionID { get; set; }
        public Position Position { get; set; }
    }
}
