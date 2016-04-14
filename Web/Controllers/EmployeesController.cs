using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        // GET: Employees/List
        public ActionResult List()
        {
            var dl = WebApiConfig.blHandler.GetAllEmployees();
            return View(dl);
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
            return this.RedirectToAction("");
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

            return View(dl);
        }

        [HttpPost]
        public ActionResult Edit(Shared.Entities.Employee employee)
        {
            WebApiConfig.blHandler.UpdateEmployee(employee);
            return this.RedirectToAction("");
        }

        // GET: Employees/Create
        [HttpGet]
        public ActionResult Create()
        {
            this.ViewBag.Type = new SelectList(this.types, "Value", "Text", 1);

            return View();
        }

        [HttpPost]
        public ActionResult Create(Shared.Entities.Employee employee)
        {
            Shared.Entities.Employee emp;
            if (employee is Shared.Entities.PartTimeEmployee)
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
            return this.RedirectToAction("");
        }
    }
}
