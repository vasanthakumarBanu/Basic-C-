using System;
class Program
{
    public static void Main(string[] args)
    {
                /*DateTime date1 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                DateTime date2 = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);
    
                int result = DateTime.Compare(date1,date2);
                if (result<0)
                {
                    Console.WriteLine("Past-Day");
                }
                else if(result == 0)
                {
                    Console.WriteLine("Today");
                }
                  else 
                {
                    Console.WriteLine("Future-day");
                }
                */
                int days =DateTime.DaysInMonth(2023,1);
                Console.WriteLine(days);
    }
                
}