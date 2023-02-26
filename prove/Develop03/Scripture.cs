class Scripture{
    private string _verse;
    private Dictionary<string, string> _referenceDictionary = new Dictionary<string, string>();
    private string[] _fileArray;

    public Scripture(){
        ReadFile();
        MakeDict();
        
    }
    
    private void MakeDict(){
        foreach(string line in _fileArray){
            string[] lineArray = line.Split('%');
            string id = lineArray[0];
            string scripture = lineArray[1];
            _referenceDictionary.Add(id, scripture);
        }

    }

    private void ReadFile(){
        _fileArray = File.ReadAllLines("scripture.txt");
    }

    private void AddScripture(string reference, string verse){
        using(StreamWriter sw = File.AppendText("scripture.txt")){
            sw.WriteLine();
            sw.Write(reference + "%" + verse);
        }
        Console.WriteLine("Scripture saved!");
    }

    public void AskForScripture(){
        Console.Write("What is the reference for the scripture:(Book chapter:verse) ");
        string reference = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Copy and paste the verse: ");
        string verse = Console.ReadLine();
        Console.WriteLine();
        AddScripture(reference, verse);
        UserMadeMemorizer(verse);
    }

    public void Options(){
        foreach(var (k, v) in _referenceDictionary){
            Console.WriteLine(k);
        }
        Console.WriteLine("Which one would you like to memorize:(book chapter:verse) ");
        string userInput = Console.ReadLine();
        Memorizer(userInput);
    }

    private void Memorizer(string idReference){
        SetVerse(idReference);
        HideWords hideWords = new HideWords(_verse);
        List<string> hiddenWordsList = hideWords.GetHiddenWordsList();
        Display(hiddenWordsList);

    }

    private void UserMadeMemorizer(string verse){
        _verse = verse;
        HideWords hideWords = new HideWords(verse);
        List<string> hiddenWordsList = hideWords.GetHiddenWordsList();
        Display(hiddenWordsList);
    }

    private void SetVerse(string idReference){
        foreach(var(k, v) in _referenceDictionary){
            if(idReference == k){
                _verse = v;
            }
        }

    }

    private void Display(List<string> hiddenWordsList){
        int counter = 0;
        Console.WriteLine("Press [ENTER] to start and press enter when you are done memorizing and the program will remove a random word until there are no more words left. Good Luck!");
        Console.Write(_verse);
        while(true){
            ConsoleKeyInfo key = Console.ReadKey(true);
            if(key.Key == ConsoleKey.Enter && counter < hiddenWordsList.Count()){
                Console.Write("\r" + hiddenWordsList[counter] + "\r");
                counter++;
            }else{
                break;
            }
        }

    }
}