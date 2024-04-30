using System;
class Program
{
    public static void Main(string[] args)
    {
                string  input1 = Console.ReadLine();
                string  input2 = Console.ReadLine();
                int i;
               bool flag = true;
               
               for(i = 0;i < input1.Length;i++)
                  { flag = true;
                    if (input1[i] != input2[i])
                    {    
                        flag = false;
                        break;
                    }      
                 }
                 if(flag == true)
                 {
                    Console.WriteLine("The two strings are equal.");
                 }
                 else if (flag==false)
                 {
                     Console.WriteLine("The two strings are not equal.");
                 }
    }
}