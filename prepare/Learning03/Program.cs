using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type in the top number: ");
        int topNum = int.Parse(Console.ReadLine());
        Console.Write("Type the bottom number: ");
        int botNum = int.Parse(Console.ReadLine());

        Fraction fraction = new Fraction(topNum, botNum);
        Fraction fraction0 = new Fraction();
        Fraction fraction1 = new Fraction(topNum);

        
        Console.WriteLine(fraction0.GetFractionString());
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}