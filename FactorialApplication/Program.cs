using System;

namespace FactorialApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    int number, factorial = 1; 
                    Console.WriteLine("Please enter a number: ");
                    number = Convert.ToInt32(Console.ReadLine()); 



                    if (number < 0) // if condition

                        Console.WriteLine("Can not find the factorial of a negative number");

                    else if (number <= 1) // if "if" condition fails then else if runs

                        Console.WriteLine("Factorial of number " + number + " is " + factorial);

                    else
                    {
                        for (int counter = number; counter >= 2; counter--) //  for loop for the factorial of a number // n! = (n-1)..
                        {
                            factorial = factorial * counter;
                        }

                        Console.WriteLine("Factorial of number " + number + " is " + factorial);
                    }
                }

                catch
                {
                    Console.WriteLine("Please enter a valid value");
                }


            }
        }
    }
}
    

