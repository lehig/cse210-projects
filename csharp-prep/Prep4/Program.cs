using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = 1;
        List<int> userGeneratedList = new List<int>();

        while (userNumber != 0)
        {
            Console.Write("Type in numbers, or once you are done type '0': ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            userGeneratedList.Add(userNumber);
        }

        int totalSum = userGeneratedList.Sum();
        double average = userGeneratedList.Average();


        Console.WriteLine("Done. Here is your list that you made: ");
        Console.WriteLine(string.Join(", ", userGeneratedList));
        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The largest number is: {userGeneratedList.Max()} ");

    }

    
}