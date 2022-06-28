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

   Random Index = new Random();
   int entryIndex = Index.Next(0, 30);

   Random randomColumnLength = new Random();
   int columnLength = randomColumnLength.Next(3, 10);
   Console.WriteLine("Длина столбца символов = {0}", columnLength);

   Random randomChar = new Random();
   char[] symbolColumn = new char [screenHeight];

   for (int i = 0; i < screenHeight; i++)
   {
    symbolColumn[i] = ' ';
   }

   Console.WriteLine("entry index = {0}", entryIndex);
   
   for (int i = entryIndex; i < (columnLength + entryIndex); i++)
   {
    symbolColumn[i] = Convert.ToChar(randomChar.Next(48, 126));
   }

   for (int i = 0; i < screenHeight; i++)
   {
    Thread.Sleep(500);
    if (i == entryIndex)
    {
     Console.ForegroundColor = ConsoleColor.White;
     Console.WriteLine(symbolColumn[i]);
    }
    else if (i == entryIndex + 1)
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
    }
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