using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HammerAppMVC.Models
{
    public class Department
    {
        [Key]
        public int DepartmentNo { get; set; }
        [Required]
        [StringLength(20)]
        public string DepartmentName { get; set; }
        [Required]
        [StringLength(20)]
        public string DepartmentLocation { get; set; }

        public IList<Employee> Employees { get; set; } = new List<Employee>();
    }
}