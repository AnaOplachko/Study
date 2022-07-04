using System.Collections;

namespace OOP_14._1_Collections;

public class Collection
{
    public static IEnumerable GetEvenNum(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                yield return array[i];
        }
    }
}