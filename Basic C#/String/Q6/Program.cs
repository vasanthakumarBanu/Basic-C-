using System;

        public class Program
        {
            public static void Main(string[] args)
            {
              string str = Console.ReadLine().ToLower();
              str = str.Replace(" ",string.Empty);
              int sum = 0;
              int num = 0;
              int charr = 0;

              foreach(char i in str)
              {
                if (i == 'a'||i == 'e'||i == 'i'||i == 'o'||i == 'u')
                {
                    sum++;
                }
                else if(((int) i>31 && (int) i<46) || ((int) i>57 && (int) i<65 )||(((int) i>90)&&((int) i<96)))
                {
                    charr++;
                }
                else if (i>47 && i<58)
                {
                  charr++;
                }
                else
                {
                  num++;
                }
                    
                }
                 Console.WriteLine("Total number of vowels: "+sum);
                 Console.WriteLine("Total number of consonants: "+num);
              } 
             
            }
         

            