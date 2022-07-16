//using System.IO;

namespace PushDataToRedis
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = File.OpenText(@"data.csv");

            for (int i = 0; i < 10; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}