public class Company {
    private List<IEmployee> employees = new List<IEmployee>();

    public void HireNewEmployee(IEmployee employee) {
        employees.Add(employee);
    }

    public decimal GetMonthlySalaryTotal(){
        decimal totalSalary = 0;

        foreach (var employee in employees) {
            totalSalary += employee.GetMonthlySalary();
        }

        return totalSalary;
    }
}