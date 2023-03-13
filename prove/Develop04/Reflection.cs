public class Reflection : Activity{

    private List<string> _reflectingPhrase = new List<string>();
    private List<string> _reflectionQuestion = new List<string>();
    private List<int> _usedIndices = new List<int>();
    
    public Reflection(string startingMessage, string finishingMessage, string startingActivityMessage) : base(startingMessage, finishingMessage){
        _startingActivityMessage = startingActivityMessage;
        MakeReflectingPhraseList();
        MakeReflectionQuestionList();
        ConstructLineAnimation();
    }

    private void MakeReflectingPhraseList(){
        _reflectingPhrase.Add("Think of a time when you stood up for someone else.");
        _reflectingPhrase.Add("Think of a time when you did something really difficult.");
        _reflectingPhrase.Add("Think of a time when you helped someone in need.");
        _reflectingPhrase.Add("Think of a time when you did something truly selfless.");
    }

    private void MakeReflectionQuestionList(){
        _reflectionQuestion.Add("Why was this experience meaningful to you?");
        _reflectionQuestion.Add("Have you ever done anything like this before?");
        _reflectionQuestion.Add("How did you get started?");
        _reflectionQuestion.Add("How did you feel when it was complete?");
        _reflectionQuestion.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestion.Add("What is your favorite thing about this experience?");
        _reflectionQuestion.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestion.Add("What did you learn about yourself through this experience?");
        _reflectionQuestion.Add("How can you keep this experience in mind in the future?");
    }

    private string GetRandomReflectingPhrase(){
        int randomPromptIndex = random.Next(_reflectingPhrase.Count);
        return _reflectingPhrase[randomPromptIndex];
    }

    private string GetRandomReflectingQuestion(){
        int randomQuestionIndex = -1;
        while(!_usedIndices.Contains(randomQuestionIndex))
            _usedIndices.Add(randomQuestionIndex);
            randomQuestionIndex = random.Next(_reflectionQuestion.Count);
           
        return _reflectionQuestion[randomQuestionIndex];
    }

    public override void Execute(){
        Console.WriteLine(GetStartingMessage());
        StartingActivity();
        UserTimer();
        ProgramTimer(4);
        Console.WriteLine(GetRandomReflectingPhrase());
        for (int j = 0; j<5; j++){
            MakeAnimation();
        }
        for (int i = 0; i<3; i++){
            Console.WriteLine($"\r"+GetRandomReflectingQuestion());
            int timer = _programTimer;
            while(timer > 0){
                MakeAnimation();
                timer = timer - 400;
            }
        }
        Console.WriteLine($"\r"+GetFinishingMessage());

    }

    private void StartingActivity(){
        Console.WriteLine(_startingActivityMessage);
    }


}