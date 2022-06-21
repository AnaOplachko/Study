namespace OOP_08._3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Что мы имеем?");
            Post post = new Post();

            Array postAsArray = Enum.GetValues(typeof(Post));
            for (int i = 0; i < postAsArray.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, postAsArray.GetValue(i));
            }

            string userPostRequest;
            bool postIsCorrect = false;

            do
            {
                Console.Write("Какая должность Вас интересует: ");
                userPostRequest = Console.ReadLine();
                postIsCorrect = Enum.IsDefined(typeof(Post), userPostRequest);
                
                if (postIsCorrect == true)
                    Console.WriteLine("Все в порядке");
                else
                    Console.WriteLine("Такой должности нет");
            } while (postIsCorrect != true);

            object postAsObject = Enum.Parse(typeof(Post), userPostRequest);
            Post worker = (Post)postAsObject;

            Console.Write("Сколько часов трудился {0}?:", userPostRequest);
            var hoursAsString = Console.ReadLine();
            var hours = Convert.ToInt32(hoursAsString);

            Accauntant request = new Accauntant();

            bool needBonus = false;
            needBonus = request.AskForBonus(worker, hours);
            
            if (needBonus == true)
                Console.WriteLine("Придется раскошелиться(((");
            else
                Console.WriteLine("Йеехуу, все деньги наши, все по ТК");
            
        }
    }
}