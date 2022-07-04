namespace OOP_14._1_Collections
{
    class Program
    {
        static void Main()
        {
            int[] array = new int [10];

            Random randomNum = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNum.Next(0, 100);
                Console.WriteLine("{0}. {1}", i + 1, array[i]);
            }
            
            foreach (var item in Collection.GetEvenNum(array))
            {
                Console.WriteLine(item);
            }
        }
    }
}
