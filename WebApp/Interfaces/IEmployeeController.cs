using System;
using System.Collections.Generic;
using Shared.Entities;
using System.Web.Http;

namespace WebApp.Interfaces
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
