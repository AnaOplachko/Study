using System.Collections;

namespace A04._0;

class Program
{
    static void Main()
    {
        Hashtable friends = new Hashtable();
        
        friends.Add("Сережа Орлов", "25.04.1990");
        friends.Add("Серега Чипурин", "21.06.1990");
        friends.Add("Щин", "31.10.1957");

        Console.WriteLine("Count = " + friends.Count);

        foreach (DictionaryEntry friend in friends)
        {
            Console.WriteLine("Name {0}, Date {1}", friend.Key, friend.Value);
        }
        
        
    }
    
}
