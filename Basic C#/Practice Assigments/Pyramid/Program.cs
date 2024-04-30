using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int value = int.Parse(Console.ReadLine());
                int num = 1;
                int space = 1;
                for(int i=1;i<=value;i++)
                {
                      for (space =1;space<=(value-i);space++) 
                            
                                Console.Write(" ");
                             
                      for(num=1;num<i*2;num++)
                            
                                Console.Write("*");
                             
                            Console.WriteLine();
                }
            }
        }
          