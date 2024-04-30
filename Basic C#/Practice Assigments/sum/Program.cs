using System;
class Program
{
    public static void Main(string[] args)
    {   
        int row = 0;
        int col = 0;
        int n = int.Parse(Console.ReadLine());
            do
            {
                do{
                    Console.Write("-");
                    row++;
                    }while(row<n);
                
                
        col++;
        }while(col<n);

    
} 
}