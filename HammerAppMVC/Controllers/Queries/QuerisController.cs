using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HammerAppMVC.Models;

namespace HammerAppMVC.Controllers.Queries
{
    public class QuerisController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Queris
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult AverageSalary()
        {
            var employees = db.Employees.Include(e => e.Departments);

            List<double> salaries = (from employee in employees
                                where employee.Departments.DepartmentLocation != "London"
                                select employee.Salary).ToList();

            var averageSalary = Math.Round(salaries.Average(), 2, MidpointRounding.AwayFromZero);           

            return View(averageSalary);
        }        

        public ViewResult Salary2()
        {
            var employees = db.Employees
                .GroupBy(e => e.Salary)
                .OrderByDescending(g => g.Key)
                .Skip(1)
                .First();

            return View(employees);
        }

    }
}