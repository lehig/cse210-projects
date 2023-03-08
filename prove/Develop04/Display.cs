public class Display {
    private string _startingMessage;
    private string _prompt;
    private string _finishingMessage;
    private string _startingActivityMessage;
    private int _userTimer;

    public string GetStartingMessage(){
        return _startingMessage;
    }

    private void SetStartingMessage(){
        _startingMessage = "Welcome to the Mindfulness Program!";
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
}