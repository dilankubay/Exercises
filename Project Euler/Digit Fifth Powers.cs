/*Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
 * 1634 = 1^4 + 6^4 + 3^4 + 4^4
 * 8208 = 8^4 + 2^4 + 0^4 + 8^4
 * 9474 = 9^4 + 4^4 + 7^4 + 4^4
 As 1 = 1^4 is not a sum it is not included.
 The sum of these numbers is 1634 + 8208 + 9474 = 19316.
 Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.*/

public static class DigitFifthPower {
    public static void FifthPower()
    {
        int total = 0;
        //4-Digit Numbers
        for (int i = 1000; i < 9999; i++)
        {
            String s = i.ToString();
            int first = int.Parse(s[0].ToString()); //first digit
            int second = int.Parse(s[1].ToString()); //second digit
            int third = int.Parse(s[2].ToString()); //third digit
            int fourth = int.Parse(s[3].ToString()); //fourth digit
            
            double n = Math.Pow(first, 5) + Math.Pow(second, 5) + Math.Pow(third, 5) + Math.Pow(fourth, 5);
            if (i == (int)n)
            {
                total = total + i;
            }
        }
        //5-Digit Numbers 
        for (int i = 10000; i < 99999; i++)
        {
            String s = i.ToString();
            int first = int.Parse(s[0].ToString()); //first digit
            int second = int.Parse(s[1].ToString()); //second digit
            int third = int.Parse(s[2].ToString()); //third digit
            int fourth = int.Parse(s[3].ToString()); //fourth digit
            int fifth = int.Parse(s[4].ToString()); //fifth digit

            double n = Math.Pow(first, 5) + Math.Pow(second, 5) + Math.Pow(third, 5) + Math.Pow(fourth, 5) + Math.Pow(fifth, 5);
            if (i == (int)n)
            {
                total = total + i;
            }
        }
        //6-Digit Numbers 
        for (int i = 100000; i < 999999; i++)
        {
            String s = i.ToString();
            int first = int.Parse(s[0].ToString()); //first digit
            int second = int.Parse(s[1].ToString()); //second digit
            int third = int.Parse(s[2].ToString()); //third digit
            int fourth = int.Parse(s[3].ToString()); //fourth digit
            int fifth = int.Parse(s[4].ToString()); //fifth digit
            int sixth = int.Parse(s[5].ToString()); //sixth digit
            double n = Math.Pow(first, 5) + Math.Pow(second, 5) + Math.Pow(third, 5) + Math.Pow(fourth, 5) + Math.Pow(fifth, 5)+ Math.Pow(sixth, 5);
            if (i == (int)n)
            {
                total = total + i;
            }
        }       
        Console.WriteLine("Total: " + total);
    }
}