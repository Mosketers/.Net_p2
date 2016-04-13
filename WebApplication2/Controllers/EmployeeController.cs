using System;
using System.Collections.Generic;
using RestService.Interfaces;
using System.Web.Http;
using Shared.Entities;
using BusinessLogicLayer;
using Microsoft.AspNet.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : ApiController, IEmployeeController
    {
        public static IBLEmployees blHandler;
        public EmployeeController()
        {
            blHandler = Startup.blHandler;
        }
        public Employee Get(int idEmployee)
        {
            return blHandler.GetEmployee(idEmployee);
        }

        public IEnumerable<Employee> Get()
        {
            return blHandler.GetAllEmployees();
        }

        public bool Put(int idEmployee, [FromBody]string value)
        {
            //blHandler.UpdateEmployee(value); 
            throw new NotImplementedException();
        }

        public bool Post(int idEmployee, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int idEmployee)
        {
            blHandler.DeleteEmployee(idEmployee);
            return true;
        }
        
    }
}
