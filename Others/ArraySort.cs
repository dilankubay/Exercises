public class Program
{
    public static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 4 };
        List<int> list2 = new List<int> { 1, 3, 4 };

        List<int> mergedArray = MergeArray(list1, list2);
        List<int> sortedArray = ArraySort(mergedArray);

        // Sonucu yazdýr
        Console.WriteLine(string.Join(", ", sortedArray));
    }

    public static List<int> MergeArray(List<int> array1, List<int> array2)
    {
        List<int> newArr = new List<int>();

        // Ýlk listeyi ekle
        newArr.AddRange(array1);

        // Ýkinci listeyi ekle
        newArr.AddRange(array2);

        return newArr;
    }

    public static List<int> ArraySort(List<int> array)
    {
        // Bubble Sort ile sýralama
        for (int i = 0; i < array.Count - 1; i++)
        {
            for (int j = 0; j < array.Count - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(array, j, j + 1);
                }
            }
        }
        return array;
    }

    public static void Swap(List<int> array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}