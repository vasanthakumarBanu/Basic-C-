using System;
class Program
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string [] str = Console.ReadLine().Split(',');
        int[] arr = new int [str.Length];
        for (int i=0;i<arr.Length;i++)
        {
            arr[i] = int.Parse(str[i]);
        }

        for(int i = 0;i<arr.Length-1;i++)
        {
           if (arr[i]>arr[i+1])
           {
            Console.Write(arr[i]);
            Console.Write(" ");
           }
           
           
        }
        Console.Write(arr[arr.Length-1]);
        
        
    }
}