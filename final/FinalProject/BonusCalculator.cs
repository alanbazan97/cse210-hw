using System;
public class BonusCalculator
{
    public int Productivity { get; set; }
    public int Attendance { get; set; }

    public BonusCalculator(int productivity, int attendance)
    {
        Productivity = productivity;
        Attendance = attendance;
    }

    public decimal CalculateBonus(Employee employee)
    {
        decimal bonus = 0;

        if (employee is Manager manager)
        {
            // calculate bonus based on manager's performance
            bonus = manager.Performance * 100;
        }
        else
        {
            // calculate bonus based on employee's productivity and attendance
            bonus = (employee.CalculateBonus() * Productivity / 100) + (employee.CalculateBonus() * Attendance / 100);
        }

        return bonus;
    }
}
