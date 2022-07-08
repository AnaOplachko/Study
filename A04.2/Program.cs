namespace A04._2;

class  Program
{
    static void Main()
    {
        BinaryTree<int> instance = new BinaryTree<int>();

        Random randomNum = new Random();

        for (int i = 0; i < 10; i++)
        {
            int temp = randomNum.Next(0, 30);
            instance.Add(temp);
            Console.Write(temp + "  ");
        }

        Console.WriteLine("\nCount : {0}", instance.Count);

        Console.WriteLine(instance.Contains(29));

        instance.InOrderTraversal();

        Console.WriteLine("\nenumerator");

        foreach (var item in instance)
        {
            Console.WriteLine(item);
        }
    }
    
    //реализовать метод Contains
    // реализовать обходы дерева итеративным способом и с возвращаемым значением АйЭнумераторБТЮ
    // (что бы можно было применять в нумераторе)
}
