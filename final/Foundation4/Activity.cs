public class Activity{
    private string _date;
    private int _length;
    private double _speed;
    private double _pace;
    private double _distance;
    private string _type;
    
    public Activity( string date, int length, double distance){
        _date = date;
        _length = length;
        _distance = distance;
    }

    public virtual void CalcSpeed(){
        _speed = (_distance/GetLength())*60;
    }
    public virtual void CalcPace(){
        _pace = GetLength()/_distance;
    }
    public virtual string GetSummary(){
        return "Not in child class";
    }
    public string GetDate(){
        return _date;
    }
    public int GetLength(){
        return _length;
    }
    public double GetSpeed(){
        return _speed;
    }
    public double GetPace(){
        return _pace;
    }
    public double GetDistance(){
        return _distance;
    }
}