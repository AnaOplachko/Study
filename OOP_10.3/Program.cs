namespace OOP_10._3
{
    class Program
    {
        static void Main()
            {
                Console.WriteLine("Заполним словарь соответствие римских цифр - арабским");
                MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
                
                
                
                
                
                
                
                I   1
                    V   5
                        X   10
                            L   50  
                                C   100
                                    D   500
                                    M   1000
                Console.WriteLine(dictionary["книга"]);

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(dictionary[i]);
                }
            }
        
    }
    /*class Program
    {
        
        static void Main()
        {
            // интерфейс взаимодействия с экземпляром должен включать
            //метод добавления пар элементов
            //индексатор для получения значения элемента по указанному индексу
            //свойство гет для получения общего числа элементов
        }
    }*/
}