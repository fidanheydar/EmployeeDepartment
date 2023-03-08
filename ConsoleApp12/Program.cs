using ConsoleApp11.Models;
using System.ComponentModel.Design;

Employee employee = new Employee("Fidan", "Heydarova", 4000);
Department department = new Department("");


bool status = true;


Console.WriteLine("Select");
Console.WriteLine("1: Add Employee");
Console.WriteLine("2: Show the Employees");
Console.WriteLine("3: Exiting");

string select = Console.ReadLine();


if (select == "1")
{
    if (department.EmployeeCount > department.EmployeeLimit)
    {
        Console.WriteLine("Employee limit is 2 it is over");
    }
    else
    {
        department.AddEmployee();
    }
}
else if (select == "2")
{
    department.ShowEmployee();
}
else if (select == "3")
{
    Console.WriteLine("Exit the program");
}


Console.WriteLine("Enter the Name");
string Name = Console.ReadLine();
Console.WriteLine("Enter the Surname");
string SurName = Console.ReadLine();
Console.WriteLine("Enter the Salary");
int Salary = int.Parse(Console.ReadLine());

