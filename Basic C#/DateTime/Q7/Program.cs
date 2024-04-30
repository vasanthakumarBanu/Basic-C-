using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                DateTime date1 = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy HH:mm:ss",null);
                DateTime date2 = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy HH:mm:ss",null);
                TimeSpan date3 = date2-date1;
                Console.WriteLine(Math.Round(date3.TotalMinutes));

            }
        }
            