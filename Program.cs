using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string input;
            do
            {

                Console.WriteLine("Enter a Number between 1 and 100:");
                i = int.Parse(Console.ReadLine());
                int h = i % 2;
                if (h > 0)
                {
                    Console.WriteLine("Entered Number is an Odd Number");
                }

                else if (i >= 2 && i <= 25)
                {
                    Console.WriteLine("Entered Number is Even and less than 25");
                }

                else if (i >= 26 && i <= 60)

                {
                    Console.WriteLine("Entered Number is Even");
                }

                else if (i > 61)
                {
                    Console.WriteLine("Entered Number is Even and greater than 60");
                }

                Console.WriteLine("Continue? (y/n): ");
                input = Console.ReadLine();
            }
            while (input == "y");

           
        }

    }

}
    

