using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALEmployeesEF : IDALEmployees
    {
        static EmployeeDBContext db = new EmployeeDBContext();

        public void AddEmployee(Employee emp)
        {
            try
            {
                db.Employee.Add(emp);
                db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteEmployee(int id)
        {
            var matched_Employee = (from c in db.Employee
                                    where c.IdEmployee == id
                                    select c).SingleOrDefault();
            try
            {
                db.Employee.Remove(matched_Employee);
                db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEmployee(Employee emp)
        {
            try
            {
                var empleado = db.Employee
                    .Where(w => w.IdEmployee == emp.IdEmployee)
                    .SingleOrDefault();

                if (emp != null)
                {
                    empleado.Name = emp.Name;
                    empleado.StartDate = emp.StartDate;
                    db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                employees = db.Employee.ToList();
                return employees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee GetEmployee(int id)
        {
            Employee emp = null;

            try
            {
                emp = db.Employee
                   .Where(w => w.IdEmployee == id)
                   .SingleOrDefault();

                return emp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
