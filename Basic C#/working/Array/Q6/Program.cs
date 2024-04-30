using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int i,j,num;
                int [,] arr1 = new int [3,3];
                int [,] arr2 = new int [3,3];
                int [,] arr3 = new int [3,3];
                num = int.Parse(Console.ReadLine());
                //first matrix
                for(i=0;i<num;i++)
                {
                    for(j=0;j<num;j++)
                    {
                        arr1[i,j] = int.Parse(Console.ReadLine());
                    }
                }
                  //second matrix
                for(i=0;i<num;i++)
                {
                    for(j=0;j<num;j++)
                    {
                        arr2[i,j] = int.Parse(Console.ReadLine());
                    }
                }
                //new matrix
                for(i=0;i<num;i++)
                {
                    for(j=0;j<num;j++)
                    {
                        arr3[i,j] = arr1[i,j]+arr2[i,j];                    
                    }
                }
                //result matrix
                for(i=0;i<num;i++)
                {    
                    Console.WriteLine();
                    for(j=0;j<num;j++)
                    {
                        Console.Write("{0}\t",arr3[i,j]);
                    }
                }
            
    
            }
        }
            