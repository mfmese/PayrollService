using PayrollService.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollService.Models
{
    public class EmployeeType3 : EmployeeBase, IMonthlySalary, IOvertime
    { 
        public int OvertimeHour { get; set; }
        public int OvertimeHourlyWage { get; set; }
        public decimal MonthlySalary { get; set; }

        protected  override void CalculateSalary()
        {
            this.Salary =  this.MonthlySalary + (this.OvertimeHour * this.OvertimeHourlyWage);
        }
    }
}
