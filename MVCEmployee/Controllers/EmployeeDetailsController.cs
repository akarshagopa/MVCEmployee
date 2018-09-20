using MVCEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEmployee.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        // GET: EmployeeDetails
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmpDetails()
        {
            EmployeeDetails employee = new EmployeeDetails()
            {
                Employee_ID = "711546",
                Employee_Name = "Akarsha",
                Employee_Address = "Bangalore",
                Employee_Salary = 33333
            };
            return View(employee);
        }
    }
}
