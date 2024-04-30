using System;

        public class Program
        {
            public static void Main(string[] args)
            {
              string str3 = Console.ReadLine();
              string str4 = Console.ReadLine();
              string str1 = str3.ToUpper();
              string str2 = str3.ToUpper();
              if (str1[0]>str2[0])
              {
                Console.WriteLine(str3);
                Console.WriteLine(str4);
              }
              else if((str1[0]==str2[0]))
              {
                if((str1[1]>str2[1]))
                {
                 Console.WriteLine(str3);
                 Console.WriteLine(str4);
                }
                else
                {
                 Console.WriteLine(str4);
                 Console.WriteLine(str3);

                }
                 
                
              }
            }
        }
            