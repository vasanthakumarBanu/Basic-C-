using System;
using System.Diagnostics.Contracts;

public class Program
        {
            public static void Main(string[] args)
            {
             int num1 = int.Parse(Console.ReadLine());
             int count = 3;

             while(count>0)
             {             
                if (num1 == 0 || num1 == 1)
                {
                    Console.WriteLine(num1);
                    
                }
                else
                { bool flag = true;
                    for (int a = 2;a*a<=num1;a++)
                    {
                        if (num1%a ==0)
                        {
                            flag =false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine(num1);
                        count--;
                    }

                }
                
             }
             
            }
        }
            