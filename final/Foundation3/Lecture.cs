public class Lecture : Event{
    private string _type;
    private string _speaker;
    private int _capacity;
    public Lecture(string eventTitle, string description, string date, string time, string address, string speaker, int capacity) : base(eventTitle, description, date, time, address){
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails(){
        string fullDetail = StandardDetails();
        fullDetail += $"The Speaker Will Be {_speaker}\nLimited Capacity to {_capacity}\n";
        return fullDetail;
    }

    public override string ShortDescription(){
        return $"{GetEventTitle()} {_type} on {GetDate()}\n";
    }
}