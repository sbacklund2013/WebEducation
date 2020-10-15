using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models
{
    public class Subscriber
    {
        public Profile Profile { get; set; } 
        public int ProfileId { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }

    }
}
