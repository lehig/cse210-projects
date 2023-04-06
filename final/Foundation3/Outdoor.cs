public class Outdoor : Event{
    private string _type;
    private string _weather;
    public Outdoor(string eventTitle, string description, string date, string time, string address, string weather) : base(eventTitle, description, date, time, address){
        _weather = weather;
        _type = "Outdoor Gathering";
    }

    public override string FullDetails(){
        string fullDetail = StandardDetails();
        fullDetail += $"{_weather}\n";
        return fullDetail;
    }
    public override string ShortDescription(){
        return $"{_type} for {GetEventTitle()} on {GetDate()}\n";
    }
}