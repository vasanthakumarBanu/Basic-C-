using System;

        public class Program
        {
            public static void Main(string[] args)
            {
               DateTime date =DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                Console.WriteLine($"{date:MMMM}");
               for(int i = 1;i<12;i++) 
               {
                DateTime date2 = date.AddMonths(1);
                Console.WriteLine($"{date2:MMMM}");
                date = date2;
               }
            }
        }
            