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
    }

}
