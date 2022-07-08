namespace A03._1;

class Program
{
    public static void ShellSort(ref int[] arr)
    {
        int j;
        int step = arr.Length / 2;
        while (step > 0)
        {
            for (int i = 0; i < (arr.Length - step); i++)
            {
                j = i;
                while ((j >= 0) && (arr[j] > arr[j + step]))
                {
                    Swap(arr, j, j + step);
                    j = j - step;
                }
            }
            step = step / 2;
        }
    }

    static void Swap(int[] items, int left, int right)
    {
        if (left != right)
        {
            (items[left], items[right]) = (items[right], items[left]);
        }
    }
    
    static void Main()
    {
        Random randomNum = new Random();

        int[] array = new int [10];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomNum.Next(0, 100);
            Console.Write(array[i] + " ");
        }
        
        ShellSort(ref array);

        Console.WriteLine("\n\nafter sort");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
