using System;

        public class Program
        {
            public static void Main(string[] args)
            {
             string str1 = Console.ReadLine();
             string  str2 = Console.ReadLine();
             string [] str3 = (str1+" "+str2).Split(" ");
             int [] arr = new int [str3.Length];
            int temp = arr[1];
            string str="";

             for(int i = 0;i < str3.Length;i++)
             {
                arr[i] =int.Parse(str3[i]);
             }
              for(int i = 0;i <arr.Length;i++)
             {
                for(int j = i+1;j<arr.Length;j++)
                {
                    if(arr[i]<arr[j])
                    {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    }
                   
                }
             }
             for(int i = 0; i <arr.Length; i++)
             {
                str += arr[(arr.Length-1)-i]+" ";

             }
             Console.Write(str.TrimEnd());

            }

            
        }
            