namespace A05._2;

class Program
{
    static void Main()
    {
        AVLTree<int> multipleOne = new AVLTree<int>();
        AVLTree<int> multipleTwo = new AVLTree<int>();
        AVLTree<int> multipleSymmetricDifference = new AVLTree<int>();

        Random randomNum = new Random();
        
        for (int i = 0; i < 10; i++)
        {
            multipleOne.Add(randomNum.Next(0,30));
            multipleTwo.Add(randomNum.Next(0,30));
        }

        Console.WriteLine("First tree:");

        foreach (var item in multipleOne)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nSecond tree:");

        foreach (var item in multipleTwo)
        {
            Console.Write(item + " ");
        }

       multipleSymmetricDifference = multipleSymmetricDifference.SymmetricDifference(multipleOne, multipleTwo);

        Console.WriteLine("\nResult");

        foreach (var item in multipleSymmetricDifference)
        {
            Console.Write(item + " ");
        }
        //1. Создать Два множества авл деревьев
        //2. Получить новое множество использовав метод СимметрикДиффренс

        //Циклически (возможно лучше взять то множество что короче)
        //Взять элемент из первого множества
        //Проверить его наличие во втором множестве
        //В случае отсутствия этого элемента добавить его в третье множество
        //Варианты: проверить второе множество на первом
        //Вариант: удалить все сходные элементы, а потом последовательно перенести элементы в третье, либо в одно из двух
    }
}