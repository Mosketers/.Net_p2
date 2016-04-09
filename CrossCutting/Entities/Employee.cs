using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Shared.Entities
{
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    public abstract class Employee
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }
}
