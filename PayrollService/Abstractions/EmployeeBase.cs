namespace PayrollService.Abstractions
{
    public abstract class EmployeeBase
    {
        public string TcId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        protected abstract void CalculateSalary();
    }
}

