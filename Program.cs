using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        static double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double add(double num1, double num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            double sum = 0;
            var equation = Console.ReadLine();
           
            int i = 0;
            while (equation.ElementAt(i) != '+')
            {
                sum = sum + Convert.ToDouble(equation.end);
                ++i;
            }

            Console.WriteLine(sum);

                     

            // itrate through the total string until met with *,/,+ or -. Assume all values before that are numbers. Rearrange the equation so the highest priority
            // operation happens first, then either the one equal to it or below it. Until all numbers are used up. 


        }

    }
}