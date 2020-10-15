using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models
{
    public class Vote
    {
        public ForumPost Post { get; set; }
        public int PostId { get; set; }
        public Profile Profile { get; set; }
        public int ProfileId { get; set; }
    }
}
