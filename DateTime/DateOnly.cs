namespace DateTime;

public class DateOnly
{
    // Construction and properties
    DateOnly d1 = new DateOnly(2021, 5, 31);
    Console.WriteLine(d1.Year);      // 2021
    Console.WriteLine(d1.Month);     // 5
    Console.WriteLine(d1.Day);       // 31
    Console.WriteLine(d1.DayOfWeek); // Monday

// Manipulation
    DateOnly d2 = d1.AddMonths(1);  // You can add days, months, or years. Use negative values to subtract.
    Console.WriteLine(d2);     // "6/30/2021"  notice no time

// You can use the DayNumber property to find out how many days are between two dates
    int days = d2.DayNumber - d1.DayNumber;
    Console.WriteLine($"There are {days} days between {d1} and {d2}");

// The usual parsing and string formatting tokens all work as expected
    DateOnly d3 = DateOnly.ParseExact("31 Dec 1980", "dd MMM yyyy", CultureInfo.InvariantCulture);  // Custom format
    Console.WriteLine(d3.ToString("o", CultureInfo.InvariantCulture));   // "1980-12-31"  (ISO 8601 format)

// You can combine with a TimeOnly to get a DateTime
    DateTime dt = d3.ToDateTime(new TimeOnly(0, 0));
    Console.WriteLine(dt);       // "12/31/1980 12:00:00 AM"

// If you want the current date (in the local time zone)
    DateOnly today = DateOnly.FromDateTime(DateTime.Today);   
}