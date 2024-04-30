using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int input = int.Parse(Console.ReadLine());
                int num = input;
                int remain=0;
                int sum=0;
                int i = 0;
                
                    for(i=1;i<=num;i++)
                    { if(i<=9)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    { 
                    do{ 
                        int j=i;
                        do{
                        remain =j%10;
                        sum = sum+(remain*remain*remain);
                        j = j/10;
                        }while(j<=0);
                        if(sum==j)
                         {
                         Console.WriteLine(j);
                         }
                         i++;
                        }while(i<num);
                   
                 
                    }
                } 
    
            }
        }
          