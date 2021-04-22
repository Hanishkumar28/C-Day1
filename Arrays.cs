using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        int sum=0;
        Console.WriteLine("Enter the Elements :");
        
        for(int i=0;i<arr.Length;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
            sum=sum+arr[i];
        }
        Console.WriteLine("Sum of the elements : "+sum);
        
    }
}