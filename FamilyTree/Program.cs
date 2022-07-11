using System.Collections.Concurrent;

namespace FamilyTree
{
    class Program
    {
        static void Main()
        {
            List<Person> familyMembers = new List<Person>();

            familyMembers.Add(new Person("Anatoly Oplachko", 31, 0));
            familyMembers.Add(new Person("Sveta Chikalova", 21, 1));
            familyMembers.Add(new Person("Irina Chikalova", 60, 2));
            familyMembers.Add(new Person("Viktor Chikalov", 64, 3));
            familyMembers.Add(new Person("Vitaly Oplachko", 59,4));
            familyMembers.Add(new Person("Vale Ivanova", 83, 5));
            familyMembers.Add(new Person("Ivan Ivanov", 87, 6));
            familyMembers.Add(new Person("Andrew Ivanov", 60, 7));
            familyMembers.Add(new Person("Olga Ivanova", 24, 8));
            familyMembers.Add(new Person("Eugen Ivanov", 36, 9));
            familyMembers.Add(new Person("Nikolai Ivanov", 120, 10));
            familyMembers.Add(new Person("Mikhail Terehov", 111, 11));
            
            int[,] familyLink = new int[,]
            {
                { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 },  
                { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1 },
                { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
            };

            Family family = new Family(familyLink, familyMembers);

            Console.WriteLine("Рекурсивно");
            int sum = family.GetSumAgeDFS(familyMembers[0]);
            Console.WriteLine(sum + " лет членам");
            
            Console.WriteLine("\nОбход в глубину");
            int sum1 = family.GetSumAgeDFSNoRecurcion(familyMembers[0]);
            Console.WriteLine(sum1 + " лет членам");

            Console.WriteLine("\nОбход в ширину");
            int sum2 = family.GetSumAgeBFSNoRecurcion(familyMembers[0]);
            Console.WriteLine(sum2 + " лет членам");

        }
    }
    
}

