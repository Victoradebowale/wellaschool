using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("hello User, I am designed to Sum two numbers up and show if the sum of both numbers is less than or greater than 100");
            // Declare variables and then initialize to zero.
            double num1 = 0;
            double num2 = 0;
            // input the first number.
            Console.WriteLine("input first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            //  the second number.
            Console.WriteLine("input second number");
            num2 = Convert.ToDouble(Console.ReadLine());
            double sum;
            sum = num1 + num2;

            // Console.WriteLine(sum);
            Console.WriteLine($"The Sum of both numbers is: {num1} + {num2} = " + (sum));
            if (sum < 100)
            {
                Console.WriteLine("False, the sum is less than 100");
            }
          
                
            else
            // The line will be printed even
                // if the condition is false
                Console.WriteLine("True, the sum is greater than 100");
            


          

            // Wait for the user to respond before closing.
            Console.Write("close the Calculator ");
            Console.ReadLine();
        }
    }
}
