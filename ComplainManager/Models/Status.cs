﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplainManager.Models
{
    public class Status
    {
        //[Key]
        public int StatusID { get; set; }
        public string StatusType { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}