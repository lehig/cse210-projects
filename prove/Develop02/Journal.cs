

class Journal {
    public string Prompt(){
        Random randomNumber = new Random();
        int numGenerator = randomNumber.Next(0,2);
        string[] promptList = {"What made you smile today? :)", "How did the weather make you feel today?", "Is there anything you are excited for in the coming future?"};
        return promptList[numGenerator];
    }

    private string filePath = "journal_entry.txt";
    
    public void WriteJournalEntry(){
        JournalEntry jentry = new JournalEntry();

        string prompt = Prompt();
        Console.WriteLine(prompt + "\n");
        string entry = Console.ReadLine();

        DateTime date = DateTime.Now;

        jentry._entry = entry;
        jentry._prompt = prompt;
        jentry._date = date.ToString();

        File.AppendAllText(filePath, "Date: " + jentry._date + Environment.NewLine + "Prompt: " + jentry._prompt + Environment.NewLine + "Entry: " + jentry._entry + Environment.NewLine + "END" + Environment.NewLine );
        Console.WriteLine("Entry Saved!");

    }

    
}