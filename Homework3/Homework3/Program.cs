using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.WriteLine("Please enter the number of seconds you would like to convert");
            string textInput = Console.ReadLine();

            int input = int.Parse(textInput);
            int day = 86400;
            int hour = 3600;
            int min = 60;

            int numberOfDays = input / day;
            int numberOfHours = (input - numberOfDays * day) / hour;
            int numberOfMinutes = ((input - numberOfDays * day) - numberOfHours * hour) / min;
            int numberOfSeconds = ((input - numberOfDays * day) - numberOfHours * hour) - numberOfMinutes * min;

            Console.WriteLine("Days:\t{0,10}\nHours:\t{1,10}\nMinutes:{2,10}\nSeconds:{3,10}",
                numberOfDays, numberOfHours, numberOfMinutes, numberOfSeconds);
            Console.ReadLine();
        }
    }
}
