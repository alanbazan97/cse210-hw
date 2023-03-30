using System;
public class OutputHandler
{
    public void DisplayEmployeeInfo(Employee employee)
    {
        Console.WriteLine("Employee Information:\n");
        Console.WriteLine(employee.GetInfo());
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}
