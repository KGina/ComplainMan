using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplainManager.Models
{
    public class Rating
    {
        //[Key]
        public int RatingID { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }
        public string  UserID { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public int IssueID { get; set; }
        public virtual Issue issue { get; set; }
    }
}