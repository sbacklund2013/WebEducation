using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models
{
    public class ForumPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        //Class owns a forum
        public Class Class { get; set; }
        public Profile Author { get; set; }
        //0 or the id of the post it is replying to
        public int ParentId { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
