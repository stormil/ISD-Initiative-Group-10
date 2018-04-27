using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    struct Train
    {
        public string NameOfDestination;
        public int Number;
        public DateTime Date;
    }
    class ArrayOfTrains
    {
        private Train[] array = new Train[8];
        private static int SizeOfArray = 8;
        public void Initialisation()
        {
            for (int i = 0; i < SizeOfArray; i++)
            {
                Console.WriteLine("Input number of Train: ");
                array[i].Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input destination: ");
                array[i].NameOfDestination = Console.ReadLine();
                Console.WriteLine("Input Year, Month and Day of departure: ");
                array[i].Date = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            }
            Sorting();
        }

        public void Sorting()
        {
            Train temp;
            for (int i = 0; i < SizeOfArray - 1; i++)
            {
                for (int j = i + 1; j < SizeOfArray; j++)
                {
                    if (array[i].Number > array[j].Number)
                    {
                        temp.Date = array[i].Date;
                        temp.Number = array[i].Number;
                        temp.NameOfDestination = array[i].NameOfDestination;

                        array[i].Date = array[j].Date;
                        array[i].Number = array[j].Number;
                        array[i].NameOfDestination = array[j].NameOfDestination;

                        array[j].Date = temp.Date;
                        array[j].Number = temp.Number;
                        array[j].NameOfDestination = temp.NameOfDestination;
                    }
                }
            }
        }
        public void InfoTrain(int number)
        {
            int counter = -1;
            for (int i = 0; i < SizeOfArray; i++)
            {
                if (array[i].Number == number)
                {
                    counter = i;
                }
            }
            if (counter < 0)
            {
                Console.WriteLine("There are trains with your number not-exists");
            }
            else
            {
                Console.Write("Number of Train: ");
                Console.Write(array[counter].Number + "\n");
                Console.Write("Destination: ");
                Console.Write(array[counter].NameOfDestination + "\n");
                Console.Write("Year, Month and Day of departure: ");
                Console.Write(array[counter].Date + "\n");
            }
        }
    }
}
