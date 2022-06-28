namespace OOP_13._1_Threads
{

    class Program
    {

        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine("Secondary");
                Thread.Sleep(2000);
            }
        }

        static void Main()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();


            while (true)
            {
                Console.Write("Primary");
                Thread.Sleep(2000);
            }
        }
        /* static void Operation(object count)
         {
             int counter = (int)count;
             counter--;
             Console.WriteLine("A: {0}", counter);
             
             if (counter != 0)
                 Operation(counter);
 
             Console.WriteLine("B: {0}", counter);
         }
 
         static void Main()
         {
             ParameterizedThreadStart operation = Operation;
             Thread thread = new Thread(operation);
             thread.Start(25);
          
             Operation(25);
         }
         //написать рекурсивный метод
         //каждый новый вызов метода должен быть в новом потоке
         */

    }
}
