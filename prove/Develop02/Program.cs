using System;

class Program
{
    static void Main(string[] args)
    {
        //Main while loop of the menu
        int counter = 0;
        Search search = new Search();

        Console.WriteLine("Welcome to your Journal Program!");

        do {
            Console.Write("1. Journal \n2. Search \n3. Quit\nEnter the number associated with what you want to do: ");
            counter = int.Parse(Console.ReadLine());
            if (counter == 1){
                //This is where the journal class would be instatiated
                Journal journal = new Journal();
                journal.WriteJournalEntry();



            }
            else if (counter == 2){
                //This where the get function of the display class is called
                Console.Write("1. Enter a term to search all entries and returns line with it\n2. Enter a date to search and return the entries made on that date\nWhat would you like to search: ");
                int user = int.Parse(Console.ReadLine());
                if (user == 1){
                    search.ReturnSearchTerm();
                }
                else if (user == 2){
                   search.ReturnDateEntry();
                }
            }

            
            
        }
            while (counter != 3);
        
        Console.WriteLine("Goodbye!");

    }
}
