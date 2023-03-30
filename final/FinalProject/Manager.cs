using System;
public class Manager : Employee
{
    public int Performance { get; set; }
    public List<string> Tasks { get; set; }

    public Manager(string name, string jobTitle, decimal salary, int vacationDays, int performance, List<string> tasks)
        : base(name, jobTitle, salary, vacationDays)
    {
        Performance = performance;
        Tasks = tasks;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"Performance: {Performance}\n";
    }

    public override decimal CalculateBonus()
    {
        decimal baseBonus = base.CalculateBonus();
        decimal performanceBonus = baseBonus * ((decimal)Performance / 100);
        return baseBonus + performanceBonus;
    }

    public void AssignTasks(List<Employee> employees)
    {
        // assign tasks to employees
        // ...
    }

    public void EvaluatePerformance(Employee employee)
    {
        // evaluate the performance of an employee
        // ...
    }
}


