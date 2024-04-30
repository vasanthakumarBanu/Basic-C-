using System;
namespace ReadAndWrite;

class Program 
{
    public static void Main(string[] args)
    {
        //getting the inputs
        Console.Write("Enter Your name:");
        string name = Console.ReadLine();
        Console.Write("Enter Your Father Name:");
        string fatherName = Console.ReadLine();
        //printing the results
        // concatenation 
        Console.WriteLine(name +" "+ fatherName);
        //Placeholder
        Console.WriteLine("{0} {1}",name,fatherName);
        //Interpolation 
        Console.WriteLine($"{name} {fatherName}");
        Console.ReadKey();
    }
}
