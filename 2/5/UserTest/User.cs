using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    class User
    {
        private string _login;
        private string _name;
        private string _surname;
        private int _age;
        private DateTime _fillingDate;

        public User()
        {
            _fillingDate = DateTime.Today;
        }

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value <= 0 ? 0 : value;
            }
        }
        public DateTime FillingDate
        {
            get
            {
                return _fillingDate;
            }
        }

        public override string ToString()
        {
            return _login + " " + _name + " " + _surname + " " + _age + " " + _fillingDate;
        }

    }
}
