using System;
using Microsoft.VisualBasic;

public class Program
        {
            public static void Main(string[] args)
            {
            int date1 = int.Parse(Console.ReadLine());
            int date2 = int.Parse(Console.ReadLine());
            for (int i =date1;i<=date2;i++)
            {
                if(DateTime.IsLeapYear(i))
                {
                    Console.WriteLine(i);
                }
            }
            DateTime.IsLeapYear(1994);
            }
        }
            