using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int num =int.Parse(Console.ReadLine());
                int [,] a1 = new int [num,num];
                int [,] a2 = new int [num,num];
                int [,] a3 = new int [num,num];
                int i,j,k;
                //Array1
            for( i = 0;i<num;i++)
            {
                for( j = 0;j<num;j++)
                {
                    a1[i,j] =int.Parse(Console.ReadLine());
                }

            }
            //Array2
             for( i = 0;i<num;i++)
            {
                for( j = 0;j<num;j++)
                {
                    a2[i,j] =int.Parse(Console.ReadLine());
                }
                
            }
            //Multipilication Array
                for( i = 0;i<num;i++)
            {
                for( j = 0;j<num;j++)
                {
                    for(k=0;k<num;k++)
                    {
                        a3[i,j] +=a1[i,k]*a2[k,j];
                    }
                }
            }

            //Result
                for( i = 0;i<num;i++)
            { 
                Console.WriteLine();
                for( j = 0;j<num;j++)
                {
                   Console.Write(a3[i,j]);
                   Console.Write(" ");
                }
                
            }
        }
        }
            