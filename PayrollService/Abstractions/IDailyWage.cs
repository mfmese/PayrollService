namespace PayrollService.Abstractions
{
    public interface IDailyWage
    {
        int WorkingDays { get; set; }
        decimal DailyWage { get; set; }
    }
}
