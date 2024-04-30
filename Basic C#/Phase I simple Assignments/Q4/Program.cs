using System;

        public class Program
        {
            public static void Main(string[] args)
            {
              int num = int.Parse(Console.ReadLine());
              string [] arr = Console.ReadLine().ToString().Split(",");
              string num2=Console.ReadLine();
              int count = 0;
              foreach (string i in arr)
              {
                if( num2 == i)
                {
                    count++;
                }
                else
                {
                    continue;
                }
              }
              if (count>0)
              {
                Console.WriteLine("yes"+count);
              }
              else
              {
                Console.WriteLine("no");
              }
            }
        }
            