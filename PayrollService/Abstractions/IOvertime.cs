namespace PayrollService.Abstractions
{
    public interface IOvertime
    {
        int OvertimeHour { get; set; }
        int OvertimeHourlyWage { get; set; }
    }
}
