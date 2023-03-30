using System;

class Program
{
    static void Main(string[] args)
    {
        // create an employee list
        EmployeeList employees = new EmployeeList();

        while (true)
        {
            // display the menu
            Console.WriteLine("\nEmployee Management System\n");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. View Employee Info");
            Console.WriteLine("4. Calculate Employee Bonus");
            Console.WriteLine("5. Exit");

            // get the user's choice
            int choice = 0;
            while (choice < 1 || choice > 5)
            {
                Console.Write("\nEnter your choice (1-5): ");
                int.TryParse(Console.ReadLine(), out choice);
            }

            // process the user's choice
            switch (choice)
            {
                case 1:
                    // add an employee
                    Console.WriteLine("\nAdd Employee");
                    InputHandler input = new InputHandler();
                    Employee employee = input.GetEmployeeData();
                    employees.AddEmployee(employee);
                    Console.WriteLine($"\n{employee.Name} has been added to the employee list.");
                    break;

                case 2:
                    // remove an employee
                    Console.WriteLine("\nRemove Employee");
                    Console.Write("Enter the employee name: ");
                    string name = Console.ReadLine();
                    Employee employeeToRemove = employees.GetEmployee(name);
                    if (employeeToRemove != null)
                    {
                        employees.RemoveEmployee(employeeToRemove);
                        Console.WriteLine($"\n{employeeToRemove.Name} has been removed from the employee list.");
                    }
                    else
                    {
                        Console.WriteLine($"\nEmployee '{name}' not found in the employee list.");
                    }
                    break;

                case 3:
                    // view employee info
                    Console.WriteLine("\nView Employee Info");
                    Console.Write("Enter the employee name: ");
                    name = Console.ReadLine();
                    Employee employeeToView = employees.GetEmployee(name);
                    if (employeeToView != null)
                    {
                        Console.WriteLine($"\n{employeeToView.GetInfo()}");
                    }
                    else
                    {
                        Console.WriteLine($"\nEmployee '{name}' not found in the employee list.");
                    }
                    break;

                case 4:
                    // calculate employee bonus
                    Console.WriteLine("\nCalculate Employee Bonus");
                    int attendancePercentage = 0;
                    int productivityLevel = 0;

                    // get attendance percentage
                    Console.Write("\nEnter the attendance percentage (0-100): ");
                    int.TryParse(Console.ReadLine(), out attendancePercentage);

                    // get productivity level
                    Console.Write("Enter the productivity level (0-10): ");
                    int.TryParse(Console.ReadLine(), out productivityLevel);


                    BonusCalculator calculator = new BonusCalculator(productivityLevel, attendancePercentage);
                    foreach (Employee emp in employees.GetAllEmployees())
                    {
                        decimal bonus = calculator.CalculateBonus(emp);
                        Console.WriteLine($"\n{emp.Name} is eligible for a bonus of ${bonus:N2}.");
                    }
                    break;

                case 5:
                    // exit the program
                    Console.WriteLine("\nExiting Employee Management System...");
                    return;

                default:
                    break;
            }
        }
    }
}