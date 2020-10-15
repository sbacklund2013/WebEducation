using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models
{
    public class InterestProfile
    {
        public Interest Interest { get; set; }
        public int InterestId { get; set; }
        public Profile Profile { get; set; }
        public int ProfileId { get; set; }
    }
}
