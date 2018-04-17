using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Doe")
            {
                Position = Employee.Post.SeniorDeveloper,
                YearsOfExperience = 5
            };
            Console.WriteLine(employee.Name + " " + employee.Surname + " works at position of " + employee.Position  +
                " and earns " + employee.Salary + ". Tax: " + employee.Tax);
            Console.ReadKey();
        }
    }
}
