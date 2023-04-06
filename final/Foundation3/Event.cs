public class Event{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string eventTitle, string description, string date, string time, string address){
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails(){
        return $"Title - {_eventTitle}\nDescription - {_description}\nDate and Time - {_date} at {_time}\nAddress: {_address}\n";
    }

    public virtual string FullDetails(){
        return "Has no type of event";
    }

    public virtual string ShortDescription(){
        return "Has no type of event";
    }

    public string GetEventTitle(){
        return _eventTitle;
    }
    public string GetDate(){
        return _date;
    }
}