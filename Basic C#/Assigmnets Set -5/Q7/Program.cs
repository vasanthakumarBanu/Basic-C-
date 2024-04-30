using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                string str = Console.ReadLine();
                int num1 ;
                int sum = 0;
                foreach(char i in str)
                {
                    if((((int)i)>=48) && (((int)i)<=57))
                    {

                        num1 = i;
                       sum +=num1-48;
                    }
                }
                Console.WriteLine(sum);
            }
        }
            