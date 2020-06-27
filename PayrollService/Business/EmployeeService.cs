using PayrollService.Abstractions;
using PayrollService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollService.Business
{
    public class EmployeeService
    {
        public List<EmployeeBase> GetEmployeeList()
        {
            List<EmployeeBase> employeeList = new List<EmployeeBase>();

            EmployeeBase employee1 = new EmployeeType1()
            {
                MonthlySalary = 12000,
                Name = "Ahmet",
                Surname = "AA",
                TcId = "11111111111"
            };


            EmployeeBase employee2 = new EmployeeType2()
            {
                Name = "Mehmet",
                Surname = "MM",
                TcId = "22222222222",
                DailyWage = 400,
                WorkingDays = 22,
            };


            EmployeeBase employee3 = new EmployeeType3()
            {
                Name = "Ayşe",
                Surname = "YY",
                TcId = "33333333333",
                MonthlySalary = 13000,
                OvertimeHour = 14,
                OvertimeHourlyWage = 80
            };

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);


            List<EmployeeBase> employeeResultList = employeeList.ToList();

            return employeeResultList;
        }
    }
}
