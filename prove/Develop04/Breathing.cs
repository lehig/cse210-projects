public class Breathing : Activity{
    private List<string> _breathingMessages = new List<string>();
    public Breathing(string startingMessage, string finishingMessage, string startingActivityMessage) : base(startingMessage, finishingMessage){
        _startingActivityMessage = startingActivityMessage;
        MakeMessageList();
        ConstructLineAnimation();

    }

    private void MakeMessageList(){
        _breathingMessages.Add("Breathe in...");
        _breathingMessages.Add("Breathe out...");
    }

    

    public override void Execute(){
        Console.WriteLine(GetStartingMessage());
        StartingActivty();
        UserTimer();
        ProgramTimer(8);
        for(int i = 0; i < 8; i++){
            int breatheMessage = i % 2;
            int timer = _programTimer;
            Console.WriteLine($"\r{_breathingMessages[breatheMessage]}");
            while(timer > 0){
                MakeAnimation();
                timer = timer - 400;
            } 
        }
        Console.WriteLine($"\r"+GetFinishingMessage());
    }

    private void StartingActivty(){
        Console.WriteLine(_startingActivityMessage);
    }
    
}