using System;

        public class Program
        {
            public static void Main(string[] args)
            {
              int number = int.Parse(Console.ReadLine());
              bool istrue = PrimeCheck (number);
              if (istrue)
              {
                Console.WriteLine( number + " is a Prime Number.");
              }
              else
              {
               Console.WriteLine( number + " is not a Prime Number.");
              }
            }
            
            public static bool PrimeCheck (int num)
            {
              if (num <=2)
              {
                return false;
              }
              else{
              for(int i = 2;i*i<=num;++i)
              {
                    if(num%i==0)
                    {
                        return false;
                        
                    }                    
              }   
              }            
                 return true;
                
              
            }
        }