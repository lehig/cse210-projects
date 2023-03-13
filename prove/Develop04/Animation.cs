public class Animation{
    private List<string> lineSpinner = new List<string>();

    protected void ConstructLineAnimation(){
        lineSpinner.Add("|");
        lineSpinner.Add("\\");
        lineSpinner.Add("-");
        lineSpinner.Add("/");
    }

    protected void MakeAnimation(){
        foreach(string character in lineSpinner){
            Console.Write($"\r{character}");
            Thread.Sleep(100);
        }
    }
}