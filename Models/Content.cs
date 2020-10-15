using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public Lecture Lecture { get; set; }
    }
}
