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
        Console.WriteLine("saisir 2 dates");
        string d1 = Console.ReadLine();   
        string d2 = Console.ReadLine();
        if (DateTime.TryParse(d1, out DateTime date1))
        {
            if (DateTime.TryParse(d2, out DateTime date2))
            {
       
                
                Console.WriteLine("les 2 dates entrer on ce temps la de difference :"+(date2-date1).Days);
            

            }
        }
        DateTime partie9v1 = new DateTime(2025, 1, 1);
        DateTime partie9v2 =  partie9v1.AddDays(5);
        Console.WriteLine("la date de debut et ",partie9v1.ToString());
        Console.WriteLine("la date de fin et ",partie9v2.ToString());
        
    }
}
