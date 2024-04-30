using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int num = int.Parse(Console.ReadLine());
                string [] numbers = Console.ReadLine().ToString().Split(" ");
                int [] arr = new int [num];
            
            for(int i = 0;i<num;i++)
            {
                arr[i] =int.Parse(numbers[i]);
            }
            foreach( int i in arr)
            {
                if(i%2==0)
                {
                    Console.Write("even");
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("odd");
                    Console.Write(" ");
                }
            }

            }
        }
            