using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        bool check = false;

        if (BubbleSort(s) == BubbleSort(t))
        {
            check = true;
        }

        Console.WriteLine(check ? "YES" : "NO");
    }

    static string BubbleSort(string word)
    {
        // Convert string to char array
        char[] wordArray = word.ToCharArray();

        for (int i = 0; i < wordArray.Length; i++)
        {
            for (int j = 0; j < wordArray.Length - i - 1; j++)
            {
                if (wordArray[j] > wordArray[j + 1])
                {
                    Swap(wordArray, j, j + 1);
                }
            }
        }

        // Convert back to string and return
        return new string(wordArray);
    }

    static void Swap(char[] array, int index1, int index2)
    {
        char temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}