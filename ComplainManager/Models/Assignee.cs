using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplainManager.Models
{
    public class Assignee
    {
        //[Key]
        public int AssigneeID { get; set; }
        public string AssigneeName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Occupation { get; set; }
        public string StreetAddress { get; set; }
        public int IssueCategoryID { get; set; }
        public virtual ICollection<Issue>Issues { get; set; }


    }
}