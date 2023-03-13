public class Activity : Animation {
    protected string _startingMessage;
    private string _finishingMessage;
    protected string _startingActivityMessage;
    protected int _userTimer;
    protected int _programTimer;
    public Random random = new Random();
   

    public Activity(string startingMessage, string finishingMessage){
        _startingMessage = startingMessage;
        _finishingMessage = finishingMessage;

    }

    public virtual void Execute(){
        throw new Exception("Method not implemented in the base class");
    }

    public string GetStartingMessage(){
        return _startingMessage;
    }

    public virtual void SetStartingMessage(string startingMessage){
        _startingMessage = startingMessage;
    }

    public string GetFinishingMessage(){
        return _finishingMessage;
    }

    private void SetFinishingMessage(){
        _finishingMessage = "Good job! Hope you have a good day!";
    }
    
    public string GetStartingActivityMessage(){
        return _startingActivityMessage;
    }

    public void SetStartingActivityMessage(string message){
        _startingActivityMessage = message;
    }

    public virtual void UserTimer(){
        Console.Write("How long do you have to do this in seconds: ");
        int userTimer = int.Parse(Console.ReadLine());
        int programTimer = userTimer * 1000;    
        _userTimer = programTimer;   
    }

    public void Pause(int timer){
        Thread.Sleep(timer);
    }

    public void ProgramTimer(int classRegulator){
        double divider = _userTimer / classRegulator; //divides the user's input into 8 and will use that to make the timer
        double timer = Math.Round(divider, MidpointRounding.AwayFromZero);
        _programTimer = Convert.ToInt32(timer);   
    }
}