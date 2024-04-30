using System;

        public class Program
        {
            public static void Main(string[] args)
            {
               string num = Console.ReadLine();
               bool flag = false;
               int sum =0;
               foreach(char i in num)
               {
                flag = false;
                if ( i%2 != 0)
                {
                    sum+= i;
                }
               }
               if (sum%2 != 0)
                {
                    flag = true;
                }
                if (flag)
                {
                    Console.WriteLine("odd");
                }
                else 
                {
                    Console.WriteLine("even");

                }


            }
        }
            