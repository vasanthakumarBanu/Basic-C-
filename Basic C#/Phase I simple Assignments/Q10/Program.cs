using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                string str = Console.ReadLine().ToCharArray();
                foreach(char i in str)
                {
                    if(str[i]=='a')
                    {
                        Console.Write(str[i]);
                    }
                     else if(str[i]=="e")
                    {
                        Console.Write(str[i]);
                    }
                    else if(str[i]=="i")
                    {
                        Console.Write(str[i]);
                    }
                    else if(str[i]=="o")
                    {
                        Console.Write(str[i]);
                    }
                    else if(str[i]=="u")
                    {
                        Console.Write(str[i]);
                    }
                    else if(str[i]==" ")
                    {
                        Console.Write(str[i]);
                    }
                }
            }
        }
            