using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplainManager.Models
{
    public class Department
    {
        [Key]
        public int DepartmnentID { get; set; }
        public string DeparmentName { get; set; }
        public string Priority { get; set; }
    }
}