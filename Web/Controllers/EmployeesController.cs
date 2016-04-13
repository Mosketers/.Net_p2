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
        // GET: Employees/list
        public ActionResult List()
        {
            var dl = WebApiConfig.blHandler.GetAllEmployees();
            return View(dl);
        }
    }
}
