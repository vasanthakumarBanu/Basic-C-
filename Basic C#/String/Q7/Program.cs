using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                string str = Console.ReadLine();
                string str1 =  Console.ReadLine();
                string str2 =  Console.ReadLine();
                int i = 0;
                i = str.IndexOf(str2);
                str1 =str1.Trim()+" ";
                str = str.Insert(i,str1);
                Console.WriteLine(str);

                
            }
        }
            