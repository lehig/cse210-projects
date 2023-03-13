public class Listing : Activity{
    private int _secondsTimer;
    private List<string> _listingQuestions = new List<string>();
    public List<string> _listingAnswers = new List<string>();

    public Listing(string startingMessage, string finishingMessage, string startingActivityMessage) : base(startingMessage, finishingMessage){
        _startingActivityMessage = startingActivityMessage;
        ConstructLineAnimation();
        ConstructListingQuestions();
    }
    private void ConstructListingQuestions(){
        _listingQuestions.Add("Who are people that you appreciate?");
        _listingQuestions.Add("What are personal strengths of yours?");
        _listingQuestions.Add("Who are people that you have helped this week?");
        _listingQuestions.Add("When have you felt the Holy Ghost this month?");
        _listingQuestions.Add("Who are some of your personal heroes?");
    }

    private string GetRandomQuestion(){
        int randomQuestionIndex = random.Next(_listingQuestions.Count);
        return _listingQuestions[randomQuestionIndex];
    }

    private DateTime StartTimer(){
        Console.WriteLine($"\rReady...");
        for(int i = 0; i<2; i++){
            MakeAnimation();
        }
        Console.WriteLine($"\rBegin...");
        DateTime timer = DateTime.Now.AddSeconds(_secondsTimer);
        return timer;
    }

    public override void UserTimer(){
        Console.Write("How long do you have to do this in seconds: ");
        _secondsTimer = int.Parse(Console.ReadLine());
        int programTimer = _secondsTimer * 1000;    
        _userTimer = programTimer;
    }

    public override void Execute(){
        Console.WriteLine(GetStartingActivityMessage());
        Console.WriteLine(GetStartingMessage());
        UserTimer();
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
        _listingAnswers.Add(randomQuestion);
        Console.WriteLine("Think about it for a moment");
        for(int i = 0; i<3; i++){
            MakeAnimation();
        }
        DateTime timer = StartTimer();
        while(timer > DateTime.Now){
            string userInput = Console.ReadLine();
            _listingAnswers.Add(userInput);
        }
        ListLog.AddToFile(_listingAnswers);
        Console.WriteLine(GetFinishingMessage());
        
    }
}