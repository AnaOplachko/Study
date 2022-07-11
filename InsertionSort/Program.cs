namespace InsertionSort;

class Program
{
    static public void InsertionSort(int[] items)
    {
        int sortedRangeEndIndex = 1;

        while (sortedRangeEndIndex < items.Length)
        {
            if (items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex - 1]) < 0)   // index < index-1
            {
                int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                Insert(items, insertIndex, sortedRangeEndIndex);
            }

            sortedRangeEndIndex++;
        }
    }
    
    static private int FindInsertionIndex(int[] items, int valueToInsert)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].CompareTo(valueToInsert) > 0)
            {
                return i; 
            }
        }

        throw new InvalidOperationException("Индекс не найден");
    }

    static private void Insert(int[] itemArray, int indexInsertingAt, int indexInsertingFrom)
    {
        int temp = itemArray[indexInsertingAt];

        itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];

        for (int i = indexInsertingFrom; i > indexInsertingAt; i--)
        {
            itemArray[i] = itemArray[i - 1];
        }

        itemArray[indexInsertingAt + 1] = temp;
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
        
        InsertionSort(array);

        Console.WriteLine("\n\nafter sort");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}