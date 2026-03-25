namespace tp_dates;
using System;

class Program
{

    static void Main(string[] args)
    {
        
        DateTime time = DateTime.Now;
        Console.WriteLine(time);
        Console.WriteLine(time.ToString("dd/MM/yyyy"));

        DateTime partie2 = new DateTime(2025, 1, 1);
        Console.WriteLine(partie2.ToString("dd/MM/yyyy"));
        Console.WriteLine(partie2.ToShortDateString());
        Console.WriteLine(partie2.ToLongDateString());
        Console.WriteLine(partie2.ToString("dd/MM/yyyy"));
        Console.WriteLine(partie2.ToString("yyyy-MM-dd"));
        DateTime partie3v1 =  partie2.AddDays(10);
        Console.WriteLine(partie3v1.ToString("dd/MM/yyyy"));
        DateTime partie3v2 =  partie2.AddMonths(2);
        Console.WriteLine(partie3v2.ToString("dd/MM/yyyy"));
        DateTime partie3v3 =  partie2.AddYears(1);
        DateTime partie4v1 =  partie2.AddDays(-5);
        Console.WriteLine(partie4v1.ToString("dd/MM/yyyy"));
        DateTime partie4v2 =  partie2.AddMonths(-1);
        Console.WriteLine(partie4v2.ToString("dd/MM/yyyy"));
        
    }
}
