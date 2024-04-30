using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int rows = int.Parse(Console.ReadLine());
                for(int i = 1;i<=rows;i++)
                {
                    for(int space = 1;space <= rows-i;space++)
                    {
                        System.Console.Write(" ");
                    }
                    for(int j = 1; j<=i;j++)
                    {
                       System.Console.Write("* ");

                    }
                    System.Console.WriteLine();
                }
                 for(int k = 1;k<=rows-1;k++)
                {
                    for(int space = 1;space<=k;space++)
                    {
                        System.Console.Write(" ");
                    }
                    for(int l = 1; l<=rows-k;l++)
                    {
                        System.Console.Write("* ");
                    }
                    System.Console.WriteLine();
                }
                

                
                
               
            }
        }
            