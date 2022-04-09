using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PrimeNumber
{
    public static void Main(string[] args)
    {
        // name as the C# console calculator app.
        Console.WriteLine("Calculator to check for Prime Numbers in C#");
        int a, c, b = 0, flag = 0;
        Console.Write("Enter the Number to check if it is a prime number or not: ");
        a = int.Parse(Console.ReadLine());
        // to check for the factors of the numbers
        b = a / 2;
        for (c = 2; c <= b; c++)
        {
            if (a % c == 0)
            {
                Console.Write("Not a prime number.");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write(" Prime Number");
        // Wait for the user to respond before closing.
        Console.Write("close the Calculator by pressing any key ");
        Console.ReadLine();
    }
}