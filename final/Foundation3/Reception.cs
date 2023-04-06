public class Reception : Event{
    private string _email;
    private string _type;
    public Reception(string eventTitle, string description, string date, string time, string address, string email) : base(eventTitle, description, date, time, address){
        _email = email;
        _type = "Reception";
    }

    public override string FullDetails(){
        string fullDetail = StandardDetails();
        fullDetail += $"Please email @ {_email} to RSVP\n";
        return fullDetail;
    }
    public override string ShortDescription(){
        return $"{_type} of {GetEventTitle()} on {GetDate()}\n";
    }
}