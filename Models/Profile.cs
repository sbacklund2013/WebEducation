using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducation.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Firstname { get; set; }   
        public string Lastname { get; set; }
        public string Education { get; set; }
        public string ImagePath { get; set; }
        public ICollection<InterestProfile> Interests { get; set; }
        public ICollection<Author> AuthoredClasses { get; set;}
        public ICollection<Subscriber> SubscribedClasses { get; set; }
        public ICollection<Vote> Votes { get; set; }


    }
}
