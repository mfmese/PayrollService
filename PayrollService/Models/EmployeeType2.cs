using PayrollService.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollService.Models
{
    public class EmployeeType2 : EmployeeBase, IDailyWage
    {  
        public int WorkingDays { get; set; }
        public decimal DailyWage { get; set; }

        protected override void CalculateSalary()
        {
            this.Salary =  this.WorkingDays * this.DailyWage;
        }
    }
}
