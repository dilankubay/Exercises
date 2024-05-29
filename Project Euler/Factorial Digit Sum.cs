/* n! means = n x (n-1) x ... x 3 x 2 x 1
 * For example, 10! = 10 x 9 x ... x 3 x 2 x 1 = 3628800, and the sum of the digits in the 
 number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
* Find the sum of the digits in the number 100! */

using System.Numerics;

public class FactorialDigitSum
{
    public static BigInteger Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
    public static int SumofDigits(BigInteger n)
    {
        String s = n.ToString();
        int total = 0;
        for(int i= 0; i<s.Length; i++)
        {
            int digit = int.Parse(s[i].ToString());
            total = total + digit;          
        }
        return total;
    }
}
