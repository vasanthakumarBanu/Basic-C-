using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                
                int arr = int.Parse(Console.ReadLine());
                int[] number = new int[arr];
                string odd = string.Empty;
                string even = string.Empty;
                
                for(int i = 0;i<number.Length;i++)
                {
                    number[i] = int.Parse(Console.ReadLine());
                }
                for(int i =0;i<number.Length;i++)
                {
                    if( number[i]%2 == 0)
                    {
                        even += number[i] + " ";
                    }
                     else
                    {
                        odd += number[i]+ " ";
                    }
                }
                Console.WriteLine(odd);
                Console.WriteLine(even);
         
     }
 }
            