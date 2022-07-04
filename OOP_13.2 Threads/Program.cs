namespace OOP_13._2_Threads
{
 public class Matrix
 {

 }

 class Program
 {

  static void Main()
  {
   
   int screenHeight = 30;
   
   Random randomColumnLength = new Random();
   int columnLength = randomColumnLength.Next(3, 10);
   Console.WriteLine("Длина столбца символов = {0}", columnLength);

   Random randomChar = new Random();
   char[] symbolColumn = new char [columnLength];

   for (int i = 0; i < columnLength; i++)
   {
    symbolColumn[i] = Convert.ToChar(randomChar.Next(48, 126));
   }

   for (int i = 0; i  <  columnLength; i++)
   {
    Thread.Sleep(1000);
    Console.WriteLine(symbolColumn[i]);

   }

   
  }
 }
}

/*
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

   
   
   switch (i)
    {
     case entryIndex:
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine(symbolColumn[i]);
      break;
     case 1:
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine(symbolColumn[i]);
      break;
     default:
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine(symbolColumn[i]);
      break;
    }
*/



/*if (i == 0)
{
 Console.ForegroundColor = ConsoleColor.White;
 Console.WriteLine(symbolColumn[i]);
}
else if (i == 1)
{
 Console.ForegroundColor = ConsoleColor.Blue;
 Console.WriteLine(symbolColumn[i]);
}
else
{
 {
  Console.ForegroundColor = ConsoleColor.DarkBlue;
  Console.WriteLine(symbolColumn[i]);
 }
}*/



/*
  static void WriteSecond()
  {
   while (true)
   {
    Console.WriteLine("X");
    Thread.Sleep(10000);
   }
  }
  */
  
  /*ThreadStart writeSecond = new ThreadStart(WriteSecond);
   Thread thread = new Thread(writeSecond);
   thread.Start();
   */
   
   /*
for (int i = 0; i < screenHeight; i++)
{
 symbolColumn[i] = ' ';
}
   
for (int i = 0; i < columnLength; i++)
{
 symbolColumn[i] = Convert.ToChar(randomChar.Next(48, 126));
}
*/