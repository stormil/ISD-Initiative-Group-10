using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Employee
    {
        public enum Post
        {
            Janitor,
            JuniorDeveloper,
            MiddleDeveloper,
            SeniorDeveloper,
            TeamLead
        };

        private string name, surname;
        private Post position;
        private int yearsOfExperience;
        private double salary = 0, tax;

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int YearsOfExperience { get => yearsOfExperience; set => yearsOfExperience = value; }
        public Post Position { get => position; set => position = value; }
        public double Salary
        {
            get
            {
                return salary;
            }
        }

        public double Tax
        {
            get
            {
                return tax;
            }
        }

        public void CalculateSalaryAndTax()
        {
            switch (salary)
            {
                case 0:
                    salary = 200.0 + yearsOfExperience * 10;
                    break;
                case 1:
                    salary = 400.0 + yearsOfExperience * 50;
                    break;
                case 2:
                    salary = 1000.0 + yearsOfExperience * 100;
                    break;
                case 3:
                    salary = 2100.0 + yearsOfExperience * 200;
                    break;
                case 4:
                    salary = 3000.0 + yearsOfExperience * 350;
                    break;
                default:
                    break;
            }
            tax = salary * 0.2;
        }
    }
}
