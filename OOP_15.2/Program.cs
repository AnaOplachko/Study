namespace OOP_15._2
{
    static class ExtensionClass
    {
        public static Worker[] SortArrayByName(this Worker[] staff)
        {
            for (int i = 0; i < staff.Length - 1; i++)
            {
                for (int j = i + 1; j < staff.Length; j++)
                {
                    if (String.Compare(staff[i].Name, staff[j].Name) == 1)
                    {
                        (staff[i].Name, staff[j].Name) = (staff[j].Name, staff[i].Name);

                        (staff[i].Post, staff[j].Post) = (staff[j].Post, staff[i].Post);

                        (staff[i].Year, staff[j].Year) = (staff[j].Year, staff[i].Year);
                    }
                }
                
            }

            return staff;
        }
    }

    class UserException : Exception
    {
        public void CheckYear(int year)
        {
            if (year < 1940 && year > 2023)
            {
                Console.WriteLine("i know");
                throw new ArgumentOutOfRangeException(nameof(year), message: "Ой Ой Ой, быть того не может");
            }
        }
    }
        
    class Program
    {
        static void CheckYear(int year)
        {
            if (year < 1940 && year > 2023)
            {
                throw new ArgumentOutOfRangeException(nameof(year), message: "Ой Ой Ой, быть того не может");
            }
        }
        static void Main()
        {
            Worker worker = new Worker();
            
            int staffQuantity = 5;
            
            Worker[] workerArray = new Worker[staffQuantity];
            

            for (int i = 0; i < staffQuantity; i++)
            {
                Console.Write("Пожалуйста, введите фамилию и инициалы работника: ");
                var name = Console.ReadLine();

                Console.Write("Пожалуйста, введите должность работника {0}: ", name);
                var post = Console.ReadLine();
                
                Console.Write("В каком году работника {0} приняли на службу: ", name);
                var yearAsString = Console.ReadLine();
                int year = Convert.ToInt32(yearAsString);
                
                try
                {
                    CheckYear(year);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                worker = new Worker(name, post, year);
                workerArray[i] = worker;
            }


            for (int i = 0; i < workerArray.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", workerArray[i].Name, workerArray[i].Post, workerArray[i].Year);
            }

            workerArray = workerArray.SortArrayByName();

            Console.ReadLine();
            
            Console.WriteLine("После сортировки: ");
            
            for (int i = 0; i < workerArray.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", workerArray[i].Name, workerArray[i].Post, workerArray[i].Year);
            }

            Console.ReadLine();

            Console.Write("Введите стаж работы: ");
            var expirienceAsString = Console.ReadLine();
            var expirience = Convert.ToInt32(expirienceAsString);

            DateOnly today = new DateOnly();
            today = DateOnly.FromDateTime(DateTime.Today);

            for (int i = 0; i < staffQuantity; i++)
            {
                if (today.Year - workerArray[i].Year >= expirience)
                {
                    Console.WriteLine("{0} {1} {2}", workerArray[i].Name, workerArray[i].Post, workerArray[i].Year);
                }
            }
        }
    }
}