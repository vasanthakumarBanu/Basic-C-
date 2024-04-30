using System;
class Program
{
    public static void Main(string[] args)
    {
        int arr = int.Parse(Console.ReadLine());
                int[] number = new int[arr];
                string oder = string.Empty;
                int start = 0;
                
                for(int i = 0;i<number.Length;i++)
                        {
                            number[i] = int.Parse(Console.ReadLine());
                        }
                for (int i = 0;i<=number.Length-1;i++)
                {
                    for(int j =i+1;j<number.Length;j++)
                    {
                        if (number[i]>number[j])
                        {
                            start = number[i];
                            number[i]=number[j];
                            number[j]=start;
                            
                        }
                        
                    }    
                }
                foreach (var item in number)
                {
                    Console.WriteLine(item);
                }
                
    }
}