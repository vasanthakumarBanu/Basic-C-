using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int num = int.Parse(Console.ReadLine());
                string []str = Console.ReadLine().ToString().Split(",");
                int [] arr = new int [num];
                int fpart=0;
                int lpart=0;


                for(int i = 0;i<num;i++)
                {
                    arr[i]=int.Parse(str[i]);
                }

                fpart= arr[0]+arr[1]+arr[2];
                lpart =arr[arr.Length-1]+arr[arr.Length-2]+arr[arr.Length-3];
                if(fpart == lpart)
                {
                    Console.WriteLine("1");
                }
                else{
                    Console.WriteLine("0");
                }
            }
        }
            