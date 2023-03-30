using System;
public class EmployeeList
{
    private List<Employee> Employees { get; set; }

    public EmployeeList()
    {
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public void RemoveEmployee(Employee employee)
    {
        Employees.Remove(employee);
    }

    public Employee GetEmployee(string name)
    {
        return Employees.FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public List<Employee> GetAllEmployees()
    {
        return Employees;
    }
}
