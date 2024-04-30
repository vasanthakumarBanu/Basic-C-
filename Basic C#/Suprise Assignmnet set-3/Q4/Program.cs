using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] str1 = Console.ReadLine().Split(" ");
        int num = int.Parse(Console.ReadLine());
        string[] str2 = Console.ReadLine().Split(" ");
        int[] arr = new int[str1.Length];
        string temp = "";
        for (int i = 0; i < str1.Length; i++)
        {
            arr[i] = int.Parse(str1[i]);
        }

        for (int i = 0; i < str1.Length; i++)
        {
            if (i != num)
            {
                temp += arr[i]+" ";
            }
            else
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    temp += str2[j] + " ";
                    

                }
                temp += arr[i]+" ";
            }
        }
        Console.WriteLine(temp.TrimEnd());


    }
}
