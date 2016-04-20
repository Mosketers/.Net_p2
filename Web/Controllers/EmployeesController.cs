using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class EmployeesController : Controller
    {
        List<SelectListItem> types = new List<SelectListItem>
        {
            new SelectListItem { Selected = false, Text = "FullTime", Value = "1"},
            new SelectListItem { Selected = false, Text = "PartTime", Value = "2"},
        };

        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employees/Details
        public ActionResult Details(int id)
        {
            var dl = WebApiConfig.blHandler.GetEmployee(id);
            return View(dl);
        }

        // GET: Employees/Delete
        public ActionResult Delete(int id)
        {
            var dl = WebApiConfig.blHandler.GetEmployee(id);
            return View(dl);
        }

        // GET: Employees/ConfirmDelete
        public ActionResult ConfirmDelete(int id)
        {
            WebApiConfig.blHandler.DeleteEmployee(id);
            return this.RedirectToAction("Index");
        }

        // GET: Employees/Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var dl = WebApiConfig.blHandler.GetEmployee(id);

            var emp = new EmployeeDT();

            if (dl is Shared.Entities.PartTimeEmployee)
            {
                this.ViewBag.Type = new SelectList(this.types, "Value", "Text", 2);
                emp.HourlyRate = ((Shared.Entities.PartTimeEmployee)dl).HourlyRate;
            }
            else
            {
                this.ViewBag.Type = new SelectList(this.types, "Value", "Text", 1);
                emp.Salary = ((Shared.Entities.FullTimeEmployee)dl).Salary;
            }
            
            emp.Name = dl.Name;
            emp.IdEmployee = dl.IdEmployee;
            emp.StartDate = dl.StartDate;
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeDT employee, String Type)
        {
            Shared.Entities.Employee emp;
            if (Type.Equals("2"))
            {
                emp = new Shared.Entities.PartTimeEmployee();
                ((Shared.Entities.PartTimeEmployee)emp).HourlyRate = employee.HourlyRate;
            }
            else
            {
                emp = new Shared.Entities.FullTimeEmployee();
                ((Shared.Entities.FullTimeEmployee)emp).Salary = employee.Salary;
            }

            emp.Name = employee.Name;
            emp.IdEmployee = employee.IdEmployee;
            emp.StartDate = employee.StartDate;
            WebApiConfig.blHandler.UpdateEmployee(emp);
            return this.RedirectToAction("Index");
        }

        // GET: Employees/Create
        [HttpGet]
        public ActionResult Create()
        {
            this.ViewBag.Type = new SelectList(this.types, "Value", "Text", 1);

            return View(new EmployeeDT());
        }

        [HttpPost]
        public ActionResult Create(EmployeeDT employee , String Type)
        {
            Shared.Entities.Employee emp;
            if (Type.Equals("2"))
            {
                emp = new Shared.Entities.PartTimeEmployee();
                ((Shared.Entities.PartTimeEmployee)emp).HourlyRate = employee.HourlyRate;
            }
            else
            {
                emp = new Shared.Entities.FullTimeEmployee();
                ((Shared.Entities.FullTimeEmployee)emp).Salary = employee.Salary;
            }

            emp.Name = employee.Name;
            emp.IdEmployee = employee.IdEmployee;
            emp.StartDate = employee.StartDate;

            WebApiConfig.blHandler.AddEmployee(emp);

            var hub = new Hubs.PushEmployee();
            hub.SendEmployee(employee.IdEmployee);

            return this.RedirectToAction("Index");
        }
    }
}
