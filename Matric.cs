using System.IO;
using System;

class Program
{
    static void Main()
    {
         int[,] arr = new int[2,2]; //Declaration of 2D array
        
        Console.WriteLine("Enter the Elements :");
        
        for(int row=0; row<arr.GetLength(0); row++)
        {
            for(int col=0; col<arr.GetLength(1); col++)
            {
                arr[row,col]=Convert.ToInt32(Console.ReadLine());
            }
        }
        
        Console.WriteLine("-------------Before Transpose--------------");
        for(int row=0; row<arr.GetLength(0); row++)
        {
            for(int col=0; col<arr.GetLength(1); col++)
            {
                Console.WriteLine(arr[row, col]+ "\t");
            }
        }
        
        Console.WriteLine("-------------After Transpose--------------");
        for(int row=0; row<arr.GetLength(0); row++)
        {
            for(int col=0; col<arr.GetLength(1); col++)
            {
                Console.WriteLine(arr[col, row]+ "\t");
            }
    }
}