namespace OOP_08._1
{
    static class Program
    {
        static void Main()
        {
            Console.Write("Введите год рождения: ");
            var yearBirthdayAsString = Console.ReadLine();
            var yearBirthday = Convert.ToInt32(yearBirthdayAsString);
            Console.Write("Введите день рождения: ");
            var dayBirthdayAsString = Console.ReadLine();
            var dayBirthday = Convert.ToInt32(dayBirthdayAsString);
            Console.Write("Введите месяц рождения: ");
            var monthBirthdayAsString = Console.ReadLine();
            var monthBirthday = Convert.ToInt32(monthBirthdayAsString);

            DateOnly userBirthday = new DateOnly(yearBirthday, monthBirthday, dayBirthday);
            
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            
            DateOnly thisYearBirthday = new DateOnly(today.Year, monthBirthday, dayBirthday);
            DateOnly nextYearBirthday = new DateOnly(today.Year + 1, monthBirthday, dayBirthday);
            
            Console.WriteLine("Вы родились {0}\n", userBirthday);
            Console.WriteLine("Сегодня: {0}\n", today);

            var interval = today.DayNumber - userBirthday.DayNumber;
            Console.WriteLine("Прожил: {0} дней", interval);

            DateOnly firstDay = new DateOnly(1, 1, 1);
            interval = today.DayNumber - firstDay.DayNumber;
            Console.WriteLine("Со дня рождения Христа: {0} дней", interval);

            Console.ReadLine();

            int daysToBirthday = 0; 
            
            if (thisYearBirthday.DayNumber >= today.DayNumber)
            {
                daysToBirthday = thisYearBirthday.DayNumber - today.DayNumber;
            }
            else
            {
                daysToBirthday = nextYearBirthday.DayNumber - today.DayNumber;
            }
            
            Console.WriteLine("Осталось до днюхи: {0} дней", daysToBirthday);
        }
    }
}

//11651
//8722