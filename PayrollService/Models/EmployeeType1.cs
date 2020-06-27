using PayrollService.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollService.Models
{
    public class EmployeeType1 : EmployeeBase, IMonthlySalary
    {  
        public decimal MonthlySalary { get; set; }

        protected override void CalculateSalary()
        {
            this.Salary =  this.MonthlySalary;
        }
    }
}
