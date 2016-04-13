using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class EmployeesViewModel
    {
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "id")]
        public string IdEmployee { get; set; }
        [Display(Name = "StartDate")]
        public DateTime StartDate { get; set; }
    }
}