using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                string word = Console.ReadLine();
                word = word.ToLower();
                int alphasum =0;
                int digitsum =0;
                int charsum=0;
                for(int i=0;i<=word.Length;i++)
                {
                    if(word[i]>='a'&&word[i]<='z')
                    {
                     alphasum++;
                    }
                    else if(word[i]>='0'&&word[i]<='9')
                    {
                     digitsum ++;
                    }
                    else 
                    {
                     charsum++;
                    }
                }
                Console.WriteLine("The number of Alphabets in the string is: "+alphasum);
                Console.WriteLine("The number of Alphabets in the string is: "+digitsum);
                Console.WriteLine("The number of Alphabets in the string is: "+charsum);
            }
        }
            