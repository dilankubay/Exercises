/*
 Write a range function that takes two arguments, start and end, and
returns an array containing all the numbers from start up to and including
end.
Next, write a sum function that takes an array of numbers and returns
the sum of these numbers. Run the example program and see whether
it does indeed return 55.
 */
 
using System;
using System.Collections.Generic;

class Program
{
    static List<int> Range(int start, int end, int? step = null)
    {
        List<int> array = new List<int>();
        
        if (step == null)
        {
            for (int i = start; i <= end; i++)
            {
                array.Add(i);
            }
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                array.Add(i + step.Value);
            }
        }
        return array;
    }

    static int Sum(List<int> array)
    {
        int sum = 0;
        
        for (int i = 0; i < array.Count; i++)
        {
            sum += i;  // Note: Your original code adds the index, not the array value
                      // If you want to sum the array values, use: sum += array[i];
        }
        return sum;
    }

    static void Main(string[] args)
    {
        // Console.WriteLine(Sum(Range(1, 10)));
        
        var result = Range(1, 10, -1);
        
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}