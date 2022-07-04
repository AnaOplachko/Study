using System.Threading.Channels;

namespace OOP_16._4
{
    class Date
    {
        private int day, month, year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public static int operator -(Date t1, Date t2)
        {
            DateOnly d1 = new DateOnly(t1.year, t1.month, t1.day);
            DateOnly d2 = new DateOnly(t2.year, t2.month, t2.day);
            var delta = d1.DayNumber - d2.DayNumber;
            return delta;
        }
        
        public static DateOnly operator +(Date t1, int n)
        {
            DateOnly d1 = new DateOnly(t1.year, t1.month, t1.day);
            DateOnly delta = d1.AddDays(n);
            return delta;
        }
        
       // public override string ToString ("{0}. {1}. {2}", DateOnly.day, )
    }
    
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первую дату, день: ");
            var firstDayAsString = Console.ReadLine();
            var firstDay = Convert.ToInt32(firstDayAsString);
            
            Console.Write("Введите первую дату, месяц: ");
            var firstMonthAsString = Console.ReadLine();
            var firstMonth = Convert.ToInt32(firstMonthAsString);
            
            Console.Write("Введите первую дату, год: ");
            var firstYearAsString = Console.ReadLine();
            var firstYear = Convert.ToInt32(firstYearAsString);

            Date date1 = new Date(firstDay, firstMonth, firstYear);

            Console.Write("Введите вторую дату, день: ");
            var secondDayAsString = Console.ReadLine();
            var secondDay = Convert.ToInt32(secondDayAsString);
            
            Console.Write("Введите вторую дату, месяц: ");
            var secondMonthAsString = Console.ReadLine();
            var secondMonth = Convert.ToInt32(secondMonthAsString);
            
            Console.Write("Введите вторую дату, год: ");
            var secondYearAsString = Console.ReadLine();
            var secondYear = Convert.ToInt32(secondYearAsString);

            Date date2 = new Date(secondDay, secondMonth, secondYear);

            Console.WriteLine("Между этими датами {0} дней", date1 - date2);

            Console.WriteLine("Введите рандомное число, которое мы добавим в первой дате: ");
            var daysNumberAsString = Console.ReadLine();
            var dayNumber = Convert.ToInt32(daysNumberAsString);

            Console.WriteLine("Вот и новая дата {0}", date1 + dayNumber);

        }
    }
}
//мех перегрузки операторовдля определения разности двух дат в днях 
//операция увеличения даты на определенное количество дней

