

class Search {

    private string[] allLines = File.ReadAllLines("journal_entry.txt");

    public void ReturnSearchTerm(){
        Console.Write("Enter a term to search all entries: ");
        string searchTerm = Console.ReadLine();
        
        Console.WriteLine("Search Results: ");
        
        foreach (string line in allLines){
            if(line.Contains(searchTerm)){
                Console.WriteLine(line);
            }
        }

        Console.WriteLine("All results found.");
    }

    public void ReturnDateEntry(){
        Console.Write("Enter date to search all entries:(MM/DD/YYYY do not put in leading 0s) ");
        string searchDate = Console.ReadLine();

        Console.WriteLine("Search Results: \n");

        int counter = 0;

        foreach(string line in allLines){
            string[] lineArray = line.Split(' ');
            if (lineArray[0] == "Date:"){
                if (lineArray[1] == searchDate){
                    Console.WriteLine(allLines[counter]);
                    Console.WriteLine(allLines[counter+1]);
                    Console.WriteLine(allLines[counter+2]+"\n");
                    
                }
            }
            counter += 1;
        }

        Console.WriteLine("All results found.\n");

    }
}