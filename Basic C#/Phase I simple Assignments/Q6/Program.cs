using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                string date = Console.ReadLine();
                DateTime date2 ;
                bool date3 = DateTime.TryParseExact(date,"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date2);
                if (date3)
                {
                    Console.WriteLine("yes");
                    Console.WriteLine(date2);

                }
                else{
                     Console.WriteLine("no");
                } 

                
              
            }
        }
            