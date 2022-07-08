namespace A02._2;

class Program
{
    static void Main()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        int elementsQuantity = 10;
        Random randomNum = new Random();

        for (int i = 0; i < elementsQuantity; i++)
        {
            array.Add(randomNum.Next(0,30));
        }

        Console.WriteLine("after add");
        array.Show();
        array.Capacity();

        Console.WriteLine("Contains '5'         :" + array.Contains(5));
        Console.WriteLine("Contains '200'       :" + array.Contains(200));
        Console.WriteLine("Index of element '7' :" + array.IndexOf(7));

        array.RemoveAt(0);
        array.DynamicRemoveAt(1);

        Console.WriteLine("after remove");
        array.Show();
        array.Capacity();
    }
}
