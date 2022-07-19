using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {

        public void DisplayNumbers()
        {
            Console.WriteLine("Looping number between 1 to 100");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }

            }
        }

        public string DisplayReverseString()
        {
            Console.WriteLine("Please enter a string value");
            string str = Console.ReadLine();
            char[] chars = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars); 
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            a.DisplayNumbers();
           Console.WriteLine("Reversed string is  : " +  a.DisplayReverseString());
           Console.ReadKey();
           
        }
    }
}
