using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class CountToBirthday
    {
        int years;
        DateTime Age;
        DateTime birthday;
        public CountToBirthday (string birthday)
        {
            DateTime tempDate;
            if (DateTime.TryParse(birthday, out tempDate))
                Birthday = tempDate;

            Birthday.Year += (DateTime.Today.Year - Birthday.Year);
            if (DateTime.Today.Month < Birthday.Month || (DateTime.Today.Month == Birthday.Month && DateTime.Today.Day < Birthday.Day))
                years--;         
        }

        public int Years { get => years; set => years = value; }
        public DateTime Birthday
        {
            get
            {
                return this.Birthday.Year;
            }
            set
            {
                this.birthday = new DateTime(value, this.Birthday.Month, this.Birthday.Date);
            }
        }

    public override string ToString()
        {
            return "Моя дата рождения " + Birthday;
        }        
    }
}
