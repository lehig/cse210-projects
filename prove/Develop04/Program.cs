using System;

class Program
{
    static void Main(string[] args)
    {
        Display display = new Display();
        Menu();

    }

    private static void Menu(){
        Console.Write("There are three activities you can do:\n1. Breathing\n2. Reflection\n3. Listing\nWhich would you like to do: ");
        int userInput = int.Parse(Console.ReadLine());
        if (userInput == 1){
            //breathing class is initiated and gone through
        }
        else if(userInput == 2){
            //reflection class is initiated and gone through
        }
        else if(userInput == 3){
            //listing class is initiated and gone through
        }else{
            Console.WriteLine("You inputed something wrong. Try running the program again. Goodbye!");
        }
    }
}