using System;
class Program
{
    public static void Main(string[] args)
    {
        double num = double.Parse(Console.ReadLine());
               double i = 1;
               double sum = 0;
               do
               {
                sum += 1/i;
                ++i;
               }while(i<num+1);
               Console.WriteLine(sum);
               Console.WriteLine((1/2));
    }
}