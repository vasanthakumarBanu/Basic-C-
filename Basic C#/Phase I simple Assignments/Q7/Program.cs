using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int num = int.Parse(Console.ReadLine());
                string[] arr = Console.ReadLine().ToString().Split(" ");
                int [] arr1 = new int [num];

                for(int i =0;i<num;i++)
                {
                    arr1[i]=int.Parse(arr[i]);
                }
                int e = 0;
                int num2 = 0;
                foreach(int i in arr1)
                {
                    if ( i > e)
                    {
                        num2 = i;
                        e = num2;
                    }
                }
                Console.WriteLine(e);



            }
        }
            