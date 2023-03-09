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



        public void AddEmployee(ref Employee[] Emplo)
        {
            for (int CountEmployee = 1; CountEmployee <= EmployeeLimit;)
            {
                
                Employee emp = new Employee();
                Console.WriteLine($"Enter {CountEmployee} Employee Name: ");
                emp.Name = Console.ReadLine();
                Console.WriteLine($"Enter {CountEmployee } Employee Surname: ");
                emp.Surname = Console.ReadLine();
                Console.WriteLine($"Enter {CountEmployee} Employee Salary");
                emp.Salary = double.Parse(Console.ReadLine());
                if (emp.CheckSalary(emp.Salary) && emp.CheckSurname(emp.Surname) && emp.CheckName(emp.Name))
                {
                    
                    Array.Resize(ref Emplo, Emplo.Length + 1);
                    Emplo[Emplo.Length-1] = emp;
                    CountEmployee++;  

                }
                else Console.WriteLine($"Ad ve soyad boyuk herfle baslamallidi ve yalniz herflerden ibaret olmalidi, Salary min 250 olmalidi");
                
            }
            Console.WriteLine($"Employee Limit is {EmployeeLimit}");
        }

        public void ShowEmployee(ref Employee[] Emploe)
        {
            

            for (int i = 0; i < Emploe.Length; i++)
            {
                Console.WriteLine("Employee "+(i + 1)+" Name: "+Emploe[i].Name+"          Employee "+(i + 1)+ " Surname: "+Emploe[i].Surname+ "          Employee "+(i + 1)+" Salary: "+Emploe[i].Salary );
            }
        }

    }
}
