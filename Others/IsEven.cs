/* 
• Zero is even.
• One is odd.
• For any other number N, its evenness is the same as N - 2.
Define a recursive function isEven corresponding to this description.
The function should accept a single parameter (a positive, whole number)
and return a Boolean.
*/

class Program
{
    static bool IsEven(int a)
    {
        if (a == 0)
        {
            return true; // Base case: 0 is even
        }
        else if (a == 1)
        {
            return false; // Base case: 1 is odd
        }
        else
        {
            return IsEven(a - 2); // Recursive case: subtract 2 and check again
        }
    }
