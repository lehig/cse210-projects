using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter in your grade: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letterGrade = "a";
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}");

        if (grade >= 70 )
        {
            Console.WriteLine("Congratulations on passing the course!");
        }
        else if (grade < 70)
        {
            Console.WriteLine("You can always do better next time!");
        }
    }
}