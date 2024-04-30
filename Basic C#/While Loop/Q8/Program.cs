using System;

        public class Program
        {
            public static void Main(string[] args)
            {
              int num1 = int.Parse(Console.ReadLine());
              int num2 = int.Parse(Console.ReadLine());
              int num3 = 0;

            if(num1 == 0 || num2 == 0)
            {
                Console.WriteLine("-1");
            }
            else{
                 
                    if(num1>num2)
                        {
                            num3 = num2;
                        }
                    else
                        {
                            num3 = num1; 
                        }
                    for(int i = num3;i>0;i--)
                        {
                            if((num1%i==0)&&(num2%i==0))
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
               
              
                }
            }
        }
            