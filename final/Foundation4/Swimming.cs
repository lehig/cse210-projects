public class Swimming : Activity{
    private double _lapsToMiles;
    private double _speed; 
    private string _type;
    private double _pace;
    public Swimming(string date, int length, double distance) : base(date, length, distance){
        _type = "Swimming";
        LapsToMiles();
    }

    private void LapsToMiles(){
        _lapsToMiles = GetDistance()*50/1000*0.62;
    }
    public override void CalcSpeed(){
        _speed = (_lapsToMiles/GetLength())*60;
    }
    public override void CalcPace(){
        _pace = GetLength()/_lapsToMiles;
    }
    public override string GetSummary(){
        CalcPace();
        CalcSpeed();
        return $"{GetDate()} {_type} ({GetLength()} min)- Distance {_lapsToMiles} miles, Speed {_speed:n} mph, Pace: {_pace:n} min per mile";
    }
}