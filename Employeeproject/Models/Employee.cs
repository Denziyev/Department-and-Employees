using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeproject.Models
{
    internal class Employee
    {
        string _name;
        string _surname;
        double _salary;


        public string Name
        {
            get => _name;
            set
            {               
                    _name = value;               
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {               
                    _surname = value;
            }
        }

        public double Salary
        {
            get => _salary;
            set
            {
                    _salary = value;
            }
        }

        
        public bool CheckSalary(double salary)
        {
            double SalaryLimit = 250;
            bool status = false;
            if (salary >= SalaryLimit)
            {
                status = true;
            }
            return status;
        }


        public bool CheckName(string name)
        {
            int count = 0;
            bool status = false;
            for (int i = 1; i < name.Length; i++)
            {
                if ((name[0] >= 'A' && name[0] <= 'Z') && (name[i] >= 'a' && name[i] <= 'z'))
                {
                    count++;
                }
            }
            if (count == name.Length-1)
            {
                status = true;
            }
            return status;
        }

        public bool CheckSurname(string surname)
        {
            int count = 0;
            bool status = false;
            for (int i = 1; i < surname.Length; i++)
            {
                if ((surname[0] >= 'A' && surname[0] <= 'Z') && (surname[i] >= 'a' && surname[i] <= 'z'))
                {
                    count++;
                }
            }
            if (count == surname.Length-1)
            {
                status = true;
            }
            return status;
        }

      


    }
}
