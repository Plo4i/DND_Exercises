// File: Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some employees
        PartTimeEmployee ptEmployee = new PartTimeEmployee(20.5m, 80); // $20.5/hour, 80 hours/month
        FullTimeEmployee ftEmployee = new FullTimeEmployee(3000m); // $3000/month

        // Create a company and add employees
        Company company = new Company();
        company.HireNewEmployee(ptEmployee);
        company.HireNewEmployee(ftEmployee);

        // Display total monthly salary
        decimal totalSalary = company.GetMonthlySalaryTotal();
        Console.WriteLine($"Total Monthly Salary: ${totalSalary}");
    }
}
