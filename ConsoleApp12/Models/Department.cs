using ConsoleApp11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    internal class Department
    {
        public string Name;
        public int EmployeeCount = 0;
        public Employee[] employees;
        public readonly int EmployeeLimit = 2;
        public readonly int SalaryLimit = 250;


        public Department(string Name)
        {
            this.Name = Name;
        }
        public Employee[] AddEmployee()
        {
            Array.Resize(ref employees, EmployeeCount + 1);
            Console.WriteLine("Enter the Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Surname");
            string SurName = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            int Salary = int.Parse(Console.ReadLine());

            if (Salary >= 250)
            {
                AddEmployee();
            }
            else
            {
                Console.WriteLine("Salary must be 250 or more than 250");
            }
            return employees;
        }

        public void ShowEmployee()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Name:" + employee.Name, "Surname:" + employee.Surname,
                    "Salary:" + employee.Salary);
            }
            bool NameCheck(string name, string surname)
            {
                if (!char.IsUpper(name[0]) || char.IsUpper(surname[0]))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
                {
                    return false;
                }
                return true;

            }
        }

    }
}
