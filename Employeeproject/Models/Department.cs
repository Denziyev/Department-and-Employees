using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employeeproject.Models;

namespace Employeeproject.Models
{
    internal class Department
    {
        string _depname;
        public string DepName
        {
            get => _depname;
            set
            {
                _depname = value;
            }
        }

        int EmployeeLimit = 2;



        public void AddEmployee(Employee[] Emplo)
        {
            for (int CountEmployee = 1; CountEmployee <= EmployeeLimit;)
            {
                
                Employee emp = new Employee();
                Console.WriteLine($"Enter {CountEmployee} Employee Name: ");
                string Name = Console.ReadLine();
                Console.WriteLine($"Enter {CountEmployee } Employee Surname: ");
                string Surname = Console.ReadLine();
                Console.WriteLine($"Enter {CountEmployee} Employee Salary");
                double Salary = double.Parse(Console.ReadLine());
                if (emp.CheckSalary(Salary) && emp.CheckSurname(Surname) && emp.CheckName(Name))
                {
                    
                    Array.Resize(ref Emplo, Emplo.Length + 1);
                    Emplo[Emplo.Length-1] = emp;
                    CountEmployee++;

                }
                else Console.WriteLine($"Ad ve soyad boyuk herfle baslamallidi ve yalniz herflerden ibaret olmalidi, Salary min 250 olmalidi");
                
            }
            Console.WriteLine($"Employee Limit is {EmployeeLimit}");
        }
        public void ShowEmployee(Employee[] Emplo)
        {
            for (int  i = 0; i < Emplo.Length; i++)
            {
                Console.WriteLine($"Employee {i + 1} Name: {Emplo[i].Name} ,Employee {i + 1} Surname: {Emplo[i].Surname} , Employee {i + 1} Salary: {Emplo[i].Salary} ");
            }

        }
    }
}
