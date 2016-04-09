using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;
using Shared.Entities;

namespace PresentationLayerWinform
{
    public partial class EmployeeAddEdit : Form
    {
        Employee employee;

        private static ServiceReference1.ServiceEmployeesClient client;

        public EmployeeAddEdit(Employee emp, ServiceReference1.ServiceEmployeesClient cli)
        {
            this.employee = emp;
            client = cli;
            InitializeComponent();
        }

        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {
            if(this.employee != null)
            {
                this.idEmpleado.Text = this.employee.IdEmployee.ToString();
                this.nameInput.Text = this.employee.Name;
                this.dateInput.Value = this.employee.StartDate;
                if(this.employee is PartTimeEmployee)
                {
                    this.SalaryOrHourlyIput.Text = ((PartTimeEmployee)this.employee).HourlyRate.ToString();
                    this.parttime.Select();
                    SalaryOrHourly.Text = "Hourly Rate";
                }
                else
                {
                    this.SalaryOrHourlyIput.Text = ((FullTimeEmployee)this.employee).Salary.ToString();
                    this.fulltime.Select();
                    SalaryOrHourly.Text = "Salary";
                }
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Boolean isUpdate = true;
            if (this.fulltime.Checked)
            {
                if (this.employee == null)
                {
                    isUpdate = false;
                    this.employee = new FullTimeEmployee();
                    ((FullTimeEmployee)this.employee).Salary = int.Parse(this.SalaryOrHourlyIput.Text);
                }
            }
            else
            {
                if (this.employee == null)
                {
                    isUpdate = false;
                    this.employee = new PartTimeEmployee();
                    ((PartTimeEmployee)this.employee).HourlyRate = int.Parse(this.SalaryOrHourlyIput.Text);
                }
            }
            this.employee.Name = this.nameInput.Text;
            this.employee.IdEmployee = int.Parse(this.idEmpleado.Text);
            this.employee.StartDate = this.dateInput.Value;
            if (isUpdate) {
                client.UpdateEmployee(this.employee);
            }
            else
            {
                client.AddEmployee(this.employee);
            }
            
            this.Close();
        }
    }
}
