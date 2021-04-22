static void Main()
    {
        int age;
        Console.Write("Enter the age :");
        age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        
        if(age<18)
        {
            Console.WriteLine("Not able to vote");
        }
        else
        {
            Console.WriteLine("Able to vote");
        }
    }