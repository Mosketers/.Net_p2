using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class EmployeesController : Controller
    {
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
        // GET: Employees/Delete
        public ActionResult Delete(int id)
        {
            var dl = WebApiConfig.blHandler.GetEmployee(id);
            return View(dl);
        }
    }
}
