using System;
using System.Collections.Generic;
using Shared.Entities;
using System.Web.Http;
using Microsoft.AspNet.Mvc;

namespace RestService.Interfaces
{
 
    public interface IEmployeeController
    {
 
        Employee Get(int idEmployee);

        IEnumerable<Employee> Get();
 
        Boolean Put(int idEmployee, [FromBody]string value);
    
        Boolean Post (int idEmployee, [FromBody]string value);
  
        Boolean Delete(int idEmployee);

    }
}
