using System;
class Program
{
    public static void Main(string[] args)
    {
          DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            DateTime date2 = date.AddYears(-15);
            DateTime date3 = date.AddYears(15);
            Console.WriteLine($"Date:{date2.ToString("dd/MM/yyyy")}");
           // Console.WriteLine($"Day:{date2.DayOfWeek}");
            Console.WriteLine($"Date:{date3.ToString("dd/MM/yyyy")}");
           
    }       
}