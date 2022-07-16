namespace NewFamilyTree
{
    class Program
    {
        static void Main()
        {
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
            
            

        }
    }
}

