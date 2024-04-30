using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int num = int.Parse(Console.ReadLine());
                string [] str1 = Console.ReadLine().ToString().Split(",");
                int [] num1 = new int [num] ;
                string sum = "";
    
    
                for(int i=0;i<num;i++)
                {
                    num1 [i] = int.Parse(str1[i]);   
                }
                bool kodi = true;
                for(int i=0;i<num;i++)
                { 
                    if(num1 [i] == i)
                    {kodi = false;
                        sum+=i;   
                    }
                }
                Console.WriteLine(sum.TrimEnd());
                if (kodi == true)
                    {
                        Console.Write("-1");
                    }
                
                          
                }

            }

            