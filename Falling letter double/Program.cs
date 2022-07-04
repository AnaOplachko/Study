namespace Falling_letter_double
{
    class Program
    {
        static void Matrix()
        {
            while (true)
            {
                Random randomColumn = new Random();
                int columnLength = randomColumn.Next(3, 10);
                int randomPosition = randomColumn.Next(0, 200);

                for (int i = 0; i < 35; i++)
                {
                    Random randomChar = new Random();
                    char charSymbol = (char)randomChar.Next(48, 126);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(randomPosition, i);
                    Console.WriteLine((char)randomChar.Next(48, 126));

                    if (i > 0)
                    {
                        Console.SetCursorPosition(randomPosition, i - 1);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine((char)randomChar.Next(48, 126));
                        if (i > 1)
                        {
                            Console.SetCursorPosition(randomPosition, i - 2); //каким то образом вот сюда нужно добавить многократный
                                                                 //вывод симпволов то есть какой то счетчик операции и цикл?
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine((char)randomChar.Next(48, 126));
                            if (i > columnLength)
                            {
                                Console.SetCursorPosition(randomPosition, i - columnLength);
                                Console.WriteLine(" ");
                            }
                        }
                    }
                    
                    if (i == 34)
                        for (int j = 0; j < 35; j++)
                        {
                            Console.SetCursorPosition(randomPosition, j);
                            Console.WriteLine(" ");
                        }
                    
                    Thread.Sleep(100);
                }
            }
        }


        static void Main()
        {
            const int threadsNumber = 19;

            ThreadStart matrix;
            Thread thread;
            
            for (int i = 0; i < threadsNumber; i++)
            {
                matrix = new ThreadStart(Matrix);
                thread = new Thread(matrix);

                Random randomSpawn = new Random();
                Thread.Sleep(randomSpawn.Next(30,150));
                thread.Start();
            }
        }
    }
}

     