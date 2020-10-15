using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        //0 false 1 good (establishes whether classes is ready to display)
        public int Status { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
        public ICollection<Subscriber> Subscribers { get; set; }
        public ICollection<ForumPost> ForumPosts { get; set; }

    }
}
