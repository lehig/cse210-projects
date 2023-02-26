using System;

class Program{
    static void Main(string[] args){
        while (true){
            Scripture scripture = new Scripture();
            Console.WriteLine("1. Choose from one of the scriptures already saved\nOR\n2. Use your own scripture");
            Console.Write("Which would you like to do: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1){
                //Calls Scripture.Options()
                scripture.Options();
                break;
            }
            else if (userInput == 2){
                //calls Scripture.AddReference()
                scripture.AskForScripture();
                break;
            }
            else{
                Console.WriteLine("That input is invalid. Try again!");
            }
        }
    }

}