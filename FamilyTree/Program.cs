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

            Person ana = new Person("Anatoly Oplachko", 31, 0);
            SocialUnit iAm = new SocialUnit(ana);

            Person sveta = new Person("Sveta Chikalova", 21, 1);
            SocialUnit sister = new SocialUnit(sveta);

            Person irina = new Person("Irina Chikalova", 60, 2);
            Person vitek = new Person("Viktor Chikalov", 64, 3);
            SocialUnit parents = new SocialUnit(vitek, irina);
            parents.Children.Add(iAm);
            parents.Children.Add(sister);

            Person leo = new Person("Leo Ivanov", 6, 111);
            SocialUnit nephew = new SocialUnit(leo);

            Person eugen = new Person("Eugen Ivanov", 36, 9);
            SocialUnit firstCousin = new SocialUnit(eugen);
            firstCousin.Children.Add(nephew);

            Person olga = new Person("Olga Ivanova", 24, 8);
            SocialUnit secondCousin = new SocialUnit(olga);

            Person andrew = new Person("Andrew Ivanov", 60, 7);
            Person elena = new Person("Elena Ivanova", 60, 222);
            SocialUnit uncles = new SocialUnit(andrew, elena);
            uncles.Children.Add(firstCousin);
            uncles.Children.Add(secondCousin);

            Person vale = new Person("Vale Ivanova", 83, 5);
            Person ivan = new Person("Ivan Ivanov", 87, 6);
            SocialUnit grandes = new SocialUnit(ivan, vale);
            grandes.Children.Add(parents);
            grandes.Children.Add(uncles);
            
            
            

            List<SocialUnit> relatives = new List<SocialUnit>();
            relatives.Add(new SocialUnit());
            
            
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

