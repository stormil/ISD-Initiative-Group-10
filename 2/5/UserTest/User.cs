using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private DateTime fillingDate;

        public User()
        {
            fillingDate = DateTime.Today;
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value <= 0 ? 0 : value;
            }
        }
        public DateTime FillingDate
        {
            get
            {
                return fillingDate;
            }
        }

        public override string ToString()
        {
            return login + " " + name + " " + surname + " " + age + " " + fillingDate;
        }

    }
}
