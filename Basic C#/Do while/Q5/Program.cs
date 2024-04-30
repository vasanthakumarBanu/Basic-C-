using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int input = int.Parse(Console.ReadLine());
        int num1=0;
        int num = 0;
        int sum = 0;
        string len = input.ToString();
        int pow = len.Length;
        int j = 10;
        num = input;
        for(int i = 1;i<10;i++)
        {
            Console.WriteLine(i);
        }
        if(input>10)
        {      
        do
        {      
             //cubing method;
                  num = j;
        while(num>0)                    
            {       
                    num1 = num%10;
                    int mul = 1;
                    int cube = num1;
                    for(int i=0;i<pow;i++)
                        {
                            mul *= cube;
                        }
                    sum += mul;
                    num /=10;    
            }

                    if(sum == j)
                    {
                    Console.WriteLine(j);
                    }
                    sum = 0;
           ++j;
        }while(j<input);
        }
            }
        }
            