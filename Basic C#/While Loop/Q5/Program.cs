using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int num1 =int.Parse(Console.ReadLine());
                int num2 =int.Parse(Console.ReadLine());
                int min = Math.Min(num1,num2);
                int result = min;
                while(result>0)
                {
                    if(num1%result ==0 && num2%result==0)
                    {
                        break;
                    }
                    --result;
                }
                Console.WriteLine(result);

            }
        }
            