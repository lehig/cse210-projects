using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());
        WritingAssignment assignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetWritingInformation());
    }
}