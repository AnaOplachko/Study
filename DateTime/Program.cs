// Construction and properties
TimeOnly t1 = new TimeOnly(16, 30);
Console.WriteLine(t1.Hour);      // 16
Console.WriteLine(t1.Minute);    // 30
Console.WriteLine(t1.Second);    // 0

// You can add hours, minutes, or a TimeSpan (using negative values to subtract).
TimeOnly t2 = t1.AddHours(10);
Console.WriteLine(t2);     // "2:30 AM"  notice no date, and we crossed midnight

// If desired, we can tell how many days were "wrapped" as the clock passed over midnight.
TimeOnly t3 = t2.AddMinutes(5000, out int wrappedDays);
Console.WriteLine($"{t3}, {wrappedDays} days later");  // "1:50 PM, 3 days later"

// You can subtract to find out how much time has elapsed between two times.
// Use "end time - start time".  The order matters, as this is a circular clock.  For example:
TimeOnly t4 = new TimeOnly(2, 0);  //  2:00  (2:00 AM)
TimeOnly t5 = new TimeOnly(21, 0); // 21:00  (9:00 PM)
TimeSpan x = t5 - t4;
TimeSpan y = t4 - t5;
Console.WriteLine($"There are {x.TotalHours} hours between {t4} and {t5}"); // 19 hours
Console.WriteLine($"There are {y.TotalHours} hours between {t5} and {t4}"); //  5 hours

// The usual parsing and string formatting tokens all work as expected
TimeOnly t6 = TimeOnly.ParseExact("5:00 pm", "h:mm tt", CultureInfo.InvariantCulture);  // Custom format
Console.WriteLine(t6.ToString("T", CultureInfo.InvariantCulture));   // "17:00:00"  (long time format)

// You can get an equivalent TimeSpan for use with previous APIs
TimeSpan ts = t6.ToTimeSpan();
Console.WriteLine(ts);      // "17:00:00"

// Or, you can combine with a DateOnly to get a DateTime
DateTime dt = new DateOnly(1970, 1, 1).ToDateTime(t6);
Console.WriteLine(dt);       // "1/1/1970 5:00:00 PM"

// If you want the current time (in the local time zone)
TimeOnly now = TimeOnly.FromDateTime(DateTime.Now);

// You can easily tell if a time is between two other times
if (now.IsBetween(t1, t2))
    Console.WriteLine($"{now} is between {t1} and {t2}.");
else
    Console.WriteLine($"{now} is NOT between {t1} and {t2}.");