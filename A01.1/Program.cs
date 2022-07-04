using System.Collections;
using System.ComponentModel.Design.Serialization;

namespace A01._1
{
    
    class Program
    {
        public static void Display(LinkedList<int> words, string test)
        {
            Console.WriteLine(test);
            
            foreach (var word in words)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        
        static void Main()
        {
            LinkedList<int> instance = new LinkedList<int>() { };

            Random randomNum = new Random();
            
            for (int i = 0; i < 17; i++)
            {
                instance.Add(randomNum.Next(0,99));
            }
            
            Display(instance, "List");
            
            instance.RemoveEveryFive();
            
            Display(instance, "List without fifth elements");
            
            instance.Add(333);
            
            Display(instance, "add new elelment");
            
            //REMOVE

            Console.WriteLine("Копирование списка в массив");
            int[] arr = new int [20];
            
            instance.CopyTo(arr, 3);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            instance.Clear();
            Display(instance, "List is cleared");
            //написать прогу которая удаляет все узлы односвязанного списка
            //в позициях кратным пяти
        }
    }
}
