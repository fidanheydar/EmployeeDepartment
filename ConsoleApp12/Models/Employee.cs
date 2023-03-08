using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        private int _salary;

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
            }
        }

        public Employee(string Name, string Surname, int Salary)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Salary = Salary;
        }

    }
}
