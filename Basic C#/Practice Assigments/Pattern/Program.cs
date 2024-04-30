using System;
class Program
{
    public static void Main(string[] args)
    {   int n = Convert.ToInt32(Console.ReadLine());
        int pos =(n*2)-1;
        int j = 1;
        int val = 1;
        do{
            string res = null;

            for (int i=1;i<pos;i++)
            {
                res +=" ";
            }
            for(int i=0;i<j;i++)
            {
                res+=val;
            }
            Console.WriteLine(res);
            val+=1;
            pos-=2;
            j+=2;
        }while(val<=n);
    }
}