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
        Console.WriteLine("saisir une date");
        string date = Console.ReadLine();

        if (DateTime.TryParse("25/03/2026", out DateTime d))
        {
        Console.WriteLine(d);
            if(time <d)
            {
                Console.WriteLine("la date nest pas passer");
            }
            else if(time >d)
            {
                Console.WriteLine("la date est passer");
            }
            else if(time.CompareTo(d) == 0)
            {
                Console.WriteLine("la date est aujourdui");
            }
        }
        else
        {
        Console.WriteLine("Date invalide");
        }       

    }
}
