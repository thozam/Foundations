using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int result = 1;

            Console.Write("\nPlease enter a small integer: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                result = result * i;
                Console.Write("\n{0}!\t=\t{1}", i, result);
            }

            Console.Write("\n\nThe factorial of {0} is: {1}", n, result);
            Console.ReadLine();
        }
    }
}
