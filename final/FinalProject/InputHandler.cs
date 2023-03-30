using System;

public class InputHandler
{
    public Employee GetEmployeeData()
    {
        Console.WriteLine("Enter employee name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter employee job title:");
        string jobTitle = Console.ReadLine();

        Console.WriteLine("Enter employee salary:");
        decimal salary = 0;
        while (salary <= 0)
        {
            if (!decimal.TryParse(Console.ReadLine(), out salary) || salary <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive decimal value for salary:");
            }
        }

        Console.WriteLine("Enter employee vacation days:");
        int vacationDays = 0;
        while (vacationDays < 10 || vacationDays > 30)
        {
            if (!int.TryParse(Console.ReadLine(), out vacationDays) || vacationDays < 10 || vacationDays > 30)
            {
                Console.WriteLine("Invalid input. Please enter an integer value between 10 and 30 for vacation days:");
            }
        }

        return new Employee(name, jobTitle, salary, vacationDays);
    }

    public string GetCommand()
    {
        Console.WriteLine("\nEnter a command (add, remove, get, getall, exit):");
        return Console.ReadLine().ToLower();
    }
}
