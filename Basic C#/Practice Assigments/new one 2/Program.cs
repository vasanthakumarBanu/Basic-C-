using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

class Program
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
                for(int i=0;i < arr;i++)
                {
                  Add(array[i]);
                }
                Console.WriteLine(sum);
            }
            public static void Add(int arr)
            {
              sum += arr;
            }

}           
                

     