using System;
public class Employee
{
    public string Name { get; set; }
    public string JobTitle { get; set; }
    public decimal Salary { get; set; }
    public int VacationDays { get; set; }

    public Employee(string name, string jobTitle, decimal salary, int vacationDays)
    {
        Name = name;
        JobTitle = jobTitle;
        Salary = salary;
        VacationDays = vacationDays;
    }

    public virtual string GetInfo()
    {
        return $"Name: {Name}\nJob Title: {JobTitle}\nSalary: {Salary}\nVacation Days: {VacationDays}\n";
    }

    public virtual int CalculateVacationDays()
    {
        return (int)(VacationDays + (Salary / 10000));
    }

    public virtual decimal CalculateBonus()
    {
        return Salary * 0.05m;
    }
}

