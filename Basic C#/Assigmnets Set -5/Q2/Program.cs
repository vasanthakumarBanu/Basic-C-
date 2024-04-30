using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int num = int.Parse(Console.ReadLine());
                string str = Console.ReadLine();
                string str2="";
             
                if(num == 1)
                {
                       for(int i = num;i<=str.Length;)
                {
                    str2 += str[i]+" ";
                    i+=num;
                    
                }
                }
                else
                {
                    for(int i = num-1;i<=str.Length;)
                {
                    str2+=str[i]+" ";
                    i+=num; 
                }

                }

                
    
               Console.Write(str2.TrimEnd());
            }
        }
            