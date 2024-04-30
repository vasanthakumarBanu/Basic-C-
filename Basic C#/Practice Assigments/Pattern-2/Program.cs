using System;
class Program
{
    
    public static void Main(string[] args)
    {   int n = int.Parse(Console.ReadLine());
        int place =(n*2)-1;
        int j =1;
        int i = 1;
        int num = 1;
       
        do{
            string output=null;
            if(num!=n)
            {
            i=1;
            do{
                 
                output += " ";
                ++i;
              }while(i<place);
              
            }
            i = 1;

           do{
            output+=num;
            ++i;
           }while(i<=j);
            Console.WriteLine(output);
            num+=1;
            place-=2;
            j+=2;
        
        }while(num<=n);
        
    }
}