public class PartTimeEmployee : Employee{
    public decimal HourlyWage { get; set; }
    public int HoursPerMonth { get; set;}

    public PartTimeEmployee(decimal hourlyWage, int hoursPerMonth)
    {
        HourlyWage = hourlyWage;
        HoursPerMonth = hoursPerMonth;
    }

    public override decimal GetMonthlySalary() {
        return HoursPerMonth * HourlyWage;
    }
}