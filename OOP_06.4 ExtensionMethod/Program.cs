using System.Threading.Channels;

namespace OOP_06._4
{
  static class ExtensionClass
  {
    public static int[] Sort(this int[] value)
    {
      Console.WriteLine("Такой наш массив до сортировки:");
      
      for (int i = 0; i < value.Length; i++)
      {
        Console.WriteLine("{0}. {1}", i + 1, value[i]);
      }

      Console.ReadLine();
      
      Array.Sort(value);

      return value;
    }  
  }

  class Program
  {
    static void Main()
    {
      Console.WriteLine("Введите число элементов массива: ");
      var elementsQuantityAsString = Console.ReadLine();
      var elementsQuantity = Convert.ToInt32(elementsQuantityAsString);

      Random randomNum = new Random();
      int[] array = new int[elementsQuantity];

      for (int i = 0; i < elementsQuantity; i++)
      {
        array[i] = randomNum.Next(100);
      }

      array = array.Sort();

      Console.WriteLine("Вот наш красавец после:");

      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine("{0}. {1}", i + 1, array[i]);
      }
    }
  }
}