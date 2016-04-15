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

            if (dl is Shared.Entities.PartTimeEmployee)
            {
                this.ViewBag.Type = new SelectList(this.types, "Value", "Text", 2);
            }
            else
            {
                this.ViewBag.Type = new SelectList(this.types, "Value", "Text", 1);
            }
            var emp = new EmployeeDT();
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
            }
            else
            {
                emp = new Shared.Entities.FullTimeEmployee();
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
            }
            else
            {
                emp = new Shared.Entities.FullTimeEmployee();
            }

            emp.Name = employee.Name;
            emp.IdEmployee = employee.IdEmployee;
            emp.StartDate = employee.StartDate;

            WebApiConfig.blHandler.AddEmployee(emp);
            return this.RedirectToAction("Index");
        }
    }
}
