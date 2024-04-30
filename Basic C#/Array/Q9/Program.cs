using System;

        public class Program
        {
            public static void Main(string[] args)
            {
               int y = int.Parse(Console.ReadLine());
               int x = int.Parse(Console.ReadLine());
               int i,j;
               
               int [,] arr1 = new int [y,x];
               int [,] arr2 = new int [x,y];
    
               for(i=0;i<y;i++)
               {
                    for(j=0;j<x;j++)
                    {
                        arr1[i,j]=int.Parse(Console.ReadLine());
                    }
               }       

               for(i=0;i<y;i++)
               {
                 Console.WriteLine();
                    for(j=0;j<x;j++)
                    {
                    Console.Write(arr1[i,j]);
                    Console.Write("");
                    
                    }
               }
                for(i=0;i<x;i++)
               {
                 Console.WriteLine();
                    for(j=0;j<y;j++)
                    {
                     arr2[i,j]=arr1[j,i];
                    Console.Write(arr2[i,j]);
                    Console.Write(" ");
                    
                    }
               }

               

                
            }
        }
            