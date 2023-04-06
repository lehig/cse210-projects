public class Running : Activity{
    private string _type;
    public Running(string date, int length, double distance) : base(date, length, distance){
        _type = "Running";

    }
    public override string GetSummary(){
        CalcPace();
        CalcSpeed();
        return $"{GetDate()} {_type} ({GetLength()} min)- Distance {GetDistance()} miles, Speed {GetSpeed():n} mph, Pace: {GetPace():n} min per mile";
    }
}