using System;

        public class Program
        {
            public static void Main(string[] args)
            {
               int num = int.Parse(Console.ReadLine());
               string [] str = Console.ReadLine().ToString().Split(",");
               int [] arr = new int [str.Length];

               for(int i = 0;i<str.Length;i++) 
               {
                  arr[i] = int.Parse(str[i]);
               }
    
               if(arr[num-1]%2 == 0)
               {
                Console.WriteLine("even");
               }
               else
               {
                Console.WriteLine("odd");
               }

            }
        }
            