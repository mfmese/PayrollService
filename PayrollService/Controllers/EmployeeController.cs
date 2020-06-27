using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayrollService.Abstractions;
using PayrollService.Business;
using PayrollService.DTOModels;
using PayrollService.Models;

namespace PayrollService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //https://localhost:44315/api/Employee/GetPayrolls
        [HttpGet]
        [Route("GetPayrolls")]
        public ActionResult<IEnumerable<Employee>> GetPayrolls()
        {
            var employeeService = new EmployeeService();

            var employeeResultList = employeeService.GetEmployeeList();

            List<Employee> employeeResponseList = new List<Employee>();

            foreach (var employeeResult in employeeResultList)
            {
                
                Employee employeeResponse = new Employee()
                {
                    Name = employeeResult.Name,
                    TcId = employeeResult.TcId,
                    Salary = employeeResult.Salary,
                    Surname = employeeResult.Surname
                };
                employeeResponseList.Add(employeeResponse);
            }    

            return employeeResponseList;
        }
       
    }
}
