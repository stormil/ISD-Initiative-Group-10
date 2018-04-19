using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    public enum Post
    {
        Janitor,
        JuniorDeveloper,
        MiddleDeveloper,
        SeniorDeveloper,
        TeamLead
    };

    class Employee
    {
        private double salary = 0, tax;

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Employee(string name, string surname, Post position, int yearsOfExperience) : this(name, surname)
        {
            Position = position;
            YearsOfExperience = yearsOfExperience;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int YearsOfExperience { get; set; }
        public Post Position { get; set; }

        public double Salary
        {
            get
            {
                CalculateSalaryAndTax();
                return salary;
            }
        }

        public double Tax
        {
            get
            {
                CalculateSalaryAndTax();
                return tax;
            }
        }

        private void CalculateSalaryAndTax()
        {
            switch (salary)
            {
                case 0:
                    salary = 200.0 + YearsOfExperience * 10;
                    break;
                case 1:
                    salary = 400.0 + YearsOfExperience * 50;
                    break;
                case 2:
                    salary = 1000.0 + YearsOfExperience * 100;
                    break;
                case 3:
                    salary = 2100.0 + YearsOfExperience * 200;
                    break;
                case 4:
                    salary = 3000.0 + YearsOfExperience * 350;
                    break;
                default:
                    break;
            }
            tax = salary * 0.2;
        }
    }
}
