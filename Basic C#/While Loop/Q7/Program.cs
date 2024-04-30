using System;

        public class Program
        {
            public static void Main(string[] args)
            {
              double N = double.Parse(Console.ReadLine());
              int K = int.Parse(Console.ReadLine());
                bool flag = false;
              double num = N;
             double num1= 0;
              
              while(num>0)
              {
                num1 =num%10;
                if (num1>K)
                {
                    flag = true;
                    break;
                }
                  num =Math.Floor(num /=10);
              }
                    if (flag == true)
                    {
                        Console.WriteLine("no");
                    }
                    else if (flag == false)
                    {
                        Console.WriteLine("yes");
                    }
            }   
        }
    
            