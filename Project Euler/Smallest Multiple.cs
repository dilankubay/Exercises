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
