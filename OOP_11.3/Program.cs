using System.Net.Sockets;

namespace OOP_11._3 //мне кажется что задача решена в корне не верно, возможно необходимы два класса кей и валью

{
 class Dictionary<TKey, TValue>
 {
  private TKey[] key = new TKey[4];
  private TValue[] value = new TValue[4];
  private int _counter = 0;

  public int Count
  {
   get { return _counter; }
  }

  public string this[int index]
  {
   get
   {
    if (index >= 0 && index < key.Length)
     return key[index] + " - " + value[index];
    else
    {
     return "Попытка обращения за пределы массива";
    }
   }
  }

  public void Add(TKey inputKey,  TValue inputValue)
  {
   if (_counter < key.Length)
      {
       key[_counter] = inputKey;
       value[_counter] = inputValue;
       _counter++;
       return;
      }
           
   Array.Resize(ref key, key.Length * 2); 
   key[_counter] = inputKey;
   Array.Resize(ref value, value.Length * 2);
   value[_counter] = inputValue;
   _counter++;
  }

  public void Show()
  {
   for (int i = 0; i < _counter; i++)
    Console.WriteLine("{0}.Римской цифре {1} соответствует арабская {2}", i+1, key[i], value[i]);
  }
 }

 /*class Key
 { 
  private string[] _romainNum = new string [5] { "I", "V", "X", "L", "C" };
  
    public string this[int index]
    {
     get { return _romainNum[index]; }
     set { _romainNum[index] = value; }
    }
 }

 class Value
 {
  private string[] _arabicNum = new string [5] { "1", "5", "10", "50", "100" };

  public string this[int index]
  {
   get { return _arabicNum[index]; }
   set { _arabicNum[index] = value; }

  }
 }
*/


 class Program
 {
  static void Main()
  {
   Dictionary<string, string> myDictionary = new Dictionary<string, string>();
   
   myDictionary.Add("I", "1");
   myDictionary.Add("V", "5");
   myDictionary.Add("X", "10");
   myDictionary.Add("L", "50");
   myDictionary.Add("C", "100");
   myDictionary.Add("D", "500");
   myDictionary.Add("M", "1000");
   
   myDictionary.Show();

   Console.WriteLine("В словаре {0} строк", myDictionary.Count);

   while (true)
   {
    Console.Write("Введите интересующий вас индекс: ");
    var indexAsString = Console.ReadLine();
    var index = Convert.ToInt32(indexAsString);
    
    Console.WriteLine(myDictionary[index]);
   }
   
   //тут должен сделать dictionary.Add("book", "книга")
  }
 }
}
//Создайте класс Dictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
 //   использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен
//System.Collections.Generic. Минимально требуемый интерфейс взаимодействия с экземпляром,
 //   должен включать метод добавления пар элементов, индексатор для получения значения элемента по
  //  указанному индексу и свойство только для чтения для получения общего количества пар элементов.