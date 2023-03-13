using System;

class Program
{
    static void Main(string[] args)
    {
        Activity display = new Activity(null, null);
        Menu();

    }

    private static void Menu(){
        Dictionary<string, Activity> activity = new Dictionary<string, Activity>();
        activity["1"] = new Breathing("This is the Brathing Activity. Relax.", "Good job on breathing! Have a good rest of your day", null);
        activity["2"] = new Reflection("This is the Reflection Activity. Let's reflect on what's been happening.", "Good job reflecting on your life! Have a good rest of your day!", "  This activity will help you reflect on times in your life when you have shown strength and resilience.\n  This will help you recognize the power you have and how you can use it in other aspects of your life.");
        activity["3"] = new Listing("This is the Listing Activity. Let's list some things!", "Good job on listing all of those things! Have a good day!", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        activity["4"] = new ListLog();

        string userInput = "";
        while(userInput != "5"){
            Console.WriteLine("Welcome to the Meditating Programs! There are three activities you can do in this program: ");
            Console.Write("1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Display Listings\n5. Quit\nEnter one of the numbers to procede: ");
            userInput = Console.ReadLine();

            activity[userInput].Execute();
            break;
        }

        
    }
}