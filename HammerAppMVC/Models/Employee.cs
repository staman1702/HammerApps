using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HammerAppMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeNo { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public int DepartmentNo { get; set; }

        public DateTime LastModify {get;set;}

        public Department Departments { get; set; }
    }
}