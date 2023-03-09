using Employeeproject.Models;

Department department = new Department();
Console.WriteLine("Enter the Department Name:");
department.DepName = Console.ReadLine();
Employee[] Employees= new Employee[0];

department.AddEmployee(Employees);
department.ShowEmployee(Employees);