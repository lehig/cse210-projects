public class Cycling : Activity{
    private string _type;
    public Cycling(string date, int length, double distance) : base(date, length, distance){
        _type = "Cycling";
    }

    public override string GetSummary(){
        CalcPace();
        CalcSpeed();
        return $"{GetDate()} {_type} ({GetLength()} min)- Distance {GetDistance()} miles, Speed {GetSpeed():n} mph, Pace: {GetPace():n} min per mile";
    }
}