using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int num = int.Parse(Console.ReadLine());
                string []str1 = Console.ReadLine().ToString().Split(",");
                string []str2 = Console.ReadLine().ToString().Split(",");
                bool flag = true;
                          for(int i=1;i<num;i++)
                            {flag = true;
                            if(str1[i-1]!=str2[str2.Length-i])
                            {
                                flag = false;
                                break;
                            }
                            }
                            if(flag == true)
                            {
                                Console.WriteLine("yes");
                            }
                            else if (flag==false)
                            {
                                Console.WriteLine("no");
                            }
                    
            }
        }
            