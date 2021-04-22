using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the operation to do : \n1.Addition \n2.Subraction \n3.Multiplication");
        int choice=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        
        switch(choice)
        {
            case 1:
                Console.WriteLine("ADD");
                break;
            case 2:
                Console.WriteLine("SUB");
                break;
            case 3:
                Console.WriteLine("MUL");
                break;
            default:
                Console.WriteLine("Nothing");
                break;
        }
    }
}