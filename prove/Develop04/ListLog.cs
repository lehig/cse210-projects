public class ListLog : Activity{
    private string[] _fileArray;

    public ListLog() : base(null, null){
        ReadFile();
    }

    private void ReadFile(){
        _fileArray = File.ReadAllLines("log.txt");
    }

    public static void AddToFile(List<string> listings){
        foreach(string prompt in listings){
            using(StreamWriter sw = File.AppendText("log.txt")){
                sw.WriteLine();
                sw.Write(prompt);
            }
        }
        Console.WriteLine("Prompts saved!");
    }

    public override void Execute(){
        Console.WriteLine("These are all the saved prompts and listings: ");
        foreach(string line in _fileArray){
            Console.WriteLine(line);
        }
    }
}