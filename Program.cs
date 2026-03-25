namespace tp_dates;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        DateTime time = DateTime.Now;
        Console.WriteLine(time);
        Console.WriteLine(time.ToString("dd/MM/yyyy"));
        
    }

}
