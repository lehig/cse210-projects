class Fraction {
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public int GetTop(){
        return _top;
    }

    public int GetBottom(){
        return _bottom;
    }

    public void SetTop(int top){
        _top = top;
    }

    public void SetBottom(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString(){
        string topString = _top.ToString();
        string bottomString = _bottom.ToString();

        string fractionString = topString + '/' + bottomString;
        return fractionString;
    }

    public double GetDecimalValue(){
        double decimalValue = Convert.ToDouble(_top)/Convert.ToDouble(_bottom);
        return decimalValue;
    }
}