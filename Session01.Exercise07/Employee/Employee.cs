public class Employee : IEmployee{
    public int Name { get; set;}

    public virtual decimal GetMonthlySalary() { return 0; }
}