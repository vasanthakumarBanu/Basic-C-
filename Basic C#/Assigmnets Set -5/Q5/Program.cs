using System;

        public class Program
        {
            public static void Main(string[] args)
            {
             int num = int.Parse(Console.ReadLine());
             string str = Console.ReadLine();
             str = str.Replace(",",string.Empty);
             int num1 =num/2;
             int num2=0;
             foreach(char i in str)
             {
               if((int)i==80)   
               {
                num2+=1;
               }
             }
             if(num2>=num1)
             {
                 Console.WriteLine("Not Blacklisted");
             }
             else{
                Console.WriteLine("Blacklisted");
             }
            

             
            }
        }
            