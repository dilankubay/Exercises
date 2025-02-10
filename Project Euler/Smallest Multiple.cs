/*
 2520 is the smallest number that can be divided by each of the numbers from 1 to 20. 
 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/



using System;

class Program
{
    static void Main()
    {
        int x = 2520;

        for (int i = 1; i <= 20;)
        {
            if (x % i == 0)
            {
                i++;
            }
            else
            {
                x++;
                i = 1;
            }
        }

        Console.WriteLine("The number is: " + x);
    }
}
