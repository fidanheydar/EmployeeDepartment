using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    public class Department
    {
        Employee[] employees = new Employee[0];
        Employee emp;
        public string name { get; set; }
        public int SalaryLimit { get; set; } = 250;
        public int EmployeeLimit { get; set; } = 2;



        public void AddEmployee()
        {
            for (int i = 0; i <= EmployeeLimit; i++)
            {
                Console.WriteLine("Enter the Name:");
                string name=Console.ReadLine();
                while (name.Any(char.IsDigit) || !char.IsUpper(name[0]) || name.Any(char.IsSymbol))
                {
                    Console.WriteLine("Name must contain letters");
                    name = Console.ReadLine();
                }

                Console.WriteLine("Enter the Surname:");
                string surname = Console.ReadLine();
                while  (surname.Any(char.IsDigit) ||!char.IsUpper(surname[0]) || surname.Any(char.IsSymbol))
                    {
                    Console.WriteLine("Surname must contain letters");
                    surname= Console.ReadLine();
                }
                Console.WriteLine("Enter the salary:");
                int salary=int.Parse(Console.ReadLine());
                while(salary<SalaryLimit)
                {
                    Console.WriteLine("Salary must be 250 or more than 250");
                    salary=int.Parse(Console.ReadLine());
                }

                if (employees.Length < EmployeeLimit)
                {
                    emp=new Employee(name,surname,salary);
                    Array.Resize(ref employees, employees.Length+1);
                    employees[employees.Length-1] = emp;
                }
                else
                {
                    Console.WriteLine("Limit is over");
                }

                
            }
        }

        public void ShowEmployee()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name ; { employee.Name}  Surname:  {employee.Surname}");
            }
        }
    }
}

