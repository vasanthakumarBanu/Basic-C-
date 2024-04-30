using System;

        public class Program
        {
          static int sum = 0;
            public static void Main(string[] args)
            {
                int arr = int.Parse(Console.ReadLine());
                int [] array = new int [arr];
                for (int i = 0 ; i < arr;i++)
                {
                  array[i]=int.Parse(Console.ReadLine());
                }

                  int num = Add(array);
                
                Console.WriteLine(num);
            }
            public static int Add(int[] array)
            {
                foreach(int i in array )
                {
                    
                    sum += i;
                }
              return sum;
            }
        }
            