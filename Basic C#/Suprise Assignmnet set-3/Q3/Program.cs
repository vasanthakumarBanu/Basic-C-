using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int num = int.Parse(Console.ReadLine());
                string [] str = Console.ReadLine().Split(" ");
                int [] arr = new int [str.Length];
               string temp1 = "";
               string temp2 = "";

               for(int i = 0;i<str.Length;i++)
               {
                arr[i]=int.Parse(str[i]);
               }



               for(int i = 0;i<arr.Length;i++)
               {
                if(arr[i] == 0)
                {
                    temp2 += arr[i]+" ";
                }
                else
                {
                    temp1 +=arr[i]+" " ;

                }

               }
               Console.WriteLine((temp1+temp2).TrimEnd());
                
        
               
              


            }
        }
            