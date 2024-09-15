public class FullTimeEmployee : Employee{
    public decimal MonthlySalary { get; set; }

    public FullTimeEmployee(decimal monthlySalary){

        MonthlySalary = monthlySalary;
    }

    public override decimal GetMonthlySalary() { return MonthlySalary; }
}