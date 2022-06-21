using System.Drawing;

namespace OOP_08._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку: ");
            var stroka = Console.ReadLine();
            
            Console.WriteLine("Вот такие цвета у нас доступны:");
            Colors color = new Colors();

            Array colorsAsArray = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < colorsAsArray.Length; i++)
            {
                Console.WriteLine("{0:D}. {0}", colorsAsArray.GetValue(i));
            }

            string? userColorRequest = null;
            bool colorIsCorrect = false;

            do
            {
                Console.Write("Какой цвет Вам по душе? Шепните: ");
                userColorRequest = Console.ReadLine();
                colorIsCorrect = Enum.IsDefined(typeof(Colors), userColorRequest);
                
                if (colorIsCorrect == true)
                    Console.WriteLine("Все в порядке");
                else
                    Console.WriteLine("Такого цвета нет");
            } while (colorIsCorrect != true);


            object colorAsObject = Enum.Parse(typeof(Colors), userColorRequest);
            Colors userColor = (Colors)colorAsObject;
            
            if ((int)userColor == (int)(ConsoleColor)userColor)
                Console.WriteLine(userColor);
            else
            {
                (int)(Colors)userColor = (int)(ConsoleColor)userColor;
            }
            
            Console.ForegroundColor = (ConsoleColor)userColor;
                
                 Console.WriteLine(userColor);       
                 Console.WriteLine((int)userColor);
                 Console.WriteLine((int)ConsoleColor.Yellow);
            

                /*Printer printer = new Printer(stroka, userColorRequest);
                printer.Print();
    */


        }

    }
}
