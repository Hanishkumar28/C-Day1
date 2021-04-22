using System.IO;
using System;

class Program
{
    static void Main()
    {
        int firstnumber, secondnumber, result;
        
        Console.Write("Enter FirstNumber :");
        firstnumber=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        
        Console.Write("Enter SecondNumber :");
        secondnumber=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        
        result=firstnumber+secondnumber;
        Console.WriteLine("Sum of two numbers :{0}",result);
    }
}