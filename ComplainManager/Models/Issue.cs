using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplainManager.Models
{
    public class Issue
    {
        //[Key]
        public int IssueID { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public int StatusID { get; set; }
        public virtual Status status { get; set; }
        public int DepartmnentID { get; set; }
        public virtual Department department { get; set; }
        public byte[] Attachment { get; set; }
        public int Reminder { get; set; }
        public DateTime DateCreated { get; set; }
        public string IssueAddress { get; set; }
        public int AssigneeID { get; set; }
        public virtual Assignee assignee { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }

    }
}