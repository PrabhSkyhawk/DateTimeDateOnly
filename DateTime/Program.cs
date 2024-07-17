using System;
using System.Globalization;
class Program
{
    public Program()
    {
        DateTimeNow();
        DateTimeObject();
        DateTimeSpecifier();
        DateTimeStringInterpolation();
        DateTimeCustomFormatSpecifier();
        CultureInfoSpecifier();
        DateTimeParse();
        DateOnly1();
        DateOnlyMinMaxValue();
        CompareDateOnly();
        OnlyDateFromTimeDate();
        DateOnlyLongDate();
    }
    static void Main(string[] args)
    {
        new Program();
    }
    void DateTimeNow()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString("F"));
        Console.WriteLine("..........................................");
    }
    void DateTimeObject()
    {
        string[] months = {"January", "February", "March", "April", "May",
    "June", "July", "August", "September", "October", "November", "December"};

        DateTime now = DateTime.Now;

        Console.WriteLine("Today's date: {0}", now.Date);
        Console.WriteLine("Today is {0} day of {1}", now.Day, months[now.Month - 1]);
        Console.WriteLine("Today is {0} day of {1}", now.DayOfYear, now.Year);
        Console.WriteLine("Today's time: {0}", now.TimeOfDay);
        Console.WriteLine("Hour: {0}", now.Hour);
        Console.WriteLine("Minute: {0}", now.Minute);
        Console.WriteLine("Second: {0}", now.Second);
        Console.WriteLine("Millisecond: {0}", now.Millisecond);
        Console.WriteLine("The day of week: {0}", now.DayOfWeek);
        Console.WriteLine("Kind: {0}", now.Kind);
        Console.WriteLine("..........................................");
    }
    void DateTimeSpecifier()
    {
        var now = DateTime.Now;
        Console.WriteLine(now.ToString("D"));
        Console.WriteLine(now.ToString("d"));
        Console.WriteLine(now.ToString("F"));
        Console.WriteLine(now.ToString("f"));
        Console.WriteLine(now.ToString("G"));
        Console.WriteLine(now.ToString("g"));
        Console.WriteLine(now.ToString("U"));
        Console.WriteLine(now.ToString("u"));
        Console.WriteLine(now.ToString("s"));
        Console.WriteLine(now.ToString("T"));
        Console.WriteLine(now.ToString("t"));
        Console.WriteLine(now.ToString("o"));
        Console.WriteLine(now.ToString("R"));
        Console.WriteLine(now.ToString("M"));
        Console.WriteLine(now.ToString("Y"));
        Console.WriteLine("..........................................");
    }
    void DateTimeStringInterpolation()
    {
        var time = DateTime.Now;
        Console.WriteLine($"{time:D}");
        Console.WriteLine($"{time:R}");
        Console.WriteLine($"{time:u}");
        Console.WriteLine("..........................................");
    }
    void DateTimeCustomFormatSpecifier()
    {
        var now = DateTime.Now;

        Console.WriteLine(now.ToString("M/d/yy"));
        Console.WriteLine($"{now:H/m/s/tt}");
        Console.WriteLine("..........................................");
    }
    void CultureInfoSpecifier()
    {
        var now = DateTime.Now;
        var watch = CultureInfo.CreateSpecificCulture("sk-SK");
        CultureInfo.DefaultThreadCurrentCulture = watch;
        Console.WriteLine(now.ToString("D"));
        Console.WriteLine(now.ToString("G"));
        Console.WriteLine("..........................................");
    }
    void DateTimeParse()
    {
        var ds = "Thu Nov 11, 2021";
        var dt = DateTime.ParseExact(ds, "ddd MMM dd, yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(dt);

        var ds2 = "10/22/2021";
        var dt2 = DateTime.ParseExact(ds2, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(dt2);
        Console.WriteLine("..........................................");
    }
    //DATEONLY
    void DateOnly1()
    {
        DateOnly date1 = new DateOnly(2022, 10, 12);
        Console.WriteLine(date1);

        DateOnly date2 = new DateOnly(2022, 10, 12, new GregorianCalendar());
        Console.WriteLine(date2);

        DateOnly date3 = new DateOnly(2022, 10, 12, new JulianCalendar());
        Console.WriteLine(date3);
        Console.WriteLine("..........................................");
    }
    void DateOnlyMinMaxValue()
    {
        DateOnly maxdate = DateOnly.MaxValue;
        DateOnly mindate = DateOnly.MinValue;

        Console.WriteLine($"Minimuum date:" + mindate);
        Console.WriteLine($"Maximum date:" + maxdate);
        Console.WriteLine("..........................................");
    }
    void CompareDateOnly()
    {
        DateOnly d1 = new DateOnly(2022, 10, 12);
        DateOnly d2 = new DateOnly(2022, 11, 12);

        if (d1 < d2)
        {
            Console.WriteLine($"{d1} is before {d2}");
        }
        else
        {
            Console.WriteLine($"{d1} is after {d2}");
            Console.WriteLine("..........................................");
        }
    }
    void OnlyDateFromTimeDate()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now);

        DateOnly d = DateOnly.FromDateTime(now);
        Console.WriteLine(d);

        TimeOnly t = TimeOnly.FromDateTime(now);
        Console.WriteLine(t);
        Console.WriteLine("..........................................");
    }
    void DateOnlyLongDate()
    {
        DateOnly d = new DateOnly(2024, 07, 17);

        Console.WriteLine(d);
        Console.WriteLine(d.ToShortDateString());
        Console.WriteLine(d.ToLongDateString());
        Console.WriteLine("..........................................");
    }
}