using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,10);

        Console.WriteLine("Magic Number Game!");
        Console.WriteLine("Guess the magic number and win a prize!");

        int numberGuess = 0;
        while (numberGuess != magicNumber) {
            Console.Write("Guess the number: ");
            string userGuess = Console.ReadLine();
            numberGuess = int.Parse(userGuess);

            if (numberGuess == magicNumber) {
                Console.WriteLine("That's correct!");
            }
            else if(numberGuess > magicNumber) {
                Console.WriteLine("Lower! Try again!");
            }
            else if(numberGuess < magicNumber) {
                Console.WriteLine("Higher! Try again!");
            }
        }

        Console.WriteLine("Thank you for playing!");
    }
}