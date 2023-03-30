using System;
public class HRAdmin : Employee
{
    public List<string> Benefits { get; set; }

    public HRAdmin(string name, string jobTitle, decimal salary, int vacationDays) 
        : base(name, jobTitle, salary, vacationDays)
    {
        Benefits = new List<string>();
    }

    public void AddBenefits(Employee employee, List<string> benefits)
    {
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee));
        }

        employee.JobTitle = "Employee with Benefits";
        Benefits.AddRange(benefits);
    }

    public void HandleComplaint(Employee employee, string complaint)
    {
        Console.WriteLine($"HR Admin handling complaint for {employee.Name}: {complaint}");
    }
}
