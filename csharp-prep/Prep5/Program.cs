using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        string userNumber = PromptUserNumber();
        Console.WriteLine(DisplayResult(userName, userNumber));

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static string PromptUserNumber()
    {
        int userNumberSquared = 0;
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        userNumberSquared = SquareNumber(userNumber);
        string userSquared = userNumberSquared.ToString();

        return userSquared;
    }

    static int SquareNumber(int userNumber)
    {
        int userNumberSquared = userNumber * userNumber;

        return userNumberSquared;
    }

    static string DisplayResult(string userName, string userNumberSquared)
    {
        string displayResult = $"{userName}, the square of your number is {userNumberSquared}";
        return displayResult;
    }
}