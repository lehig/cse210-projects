public class Address{
    private string _streetAddress = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";
    private bool _isInUSA = true;

    public Address(string streetAddress, string city, string state, string country){
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    private void setIsInUSA(){
        if (_country != "USA"){
            _isInUSA = false;
        }
    }

    public bool InUSA(){
        setIsInUSA();
        return _isInUSA;
    }
    public string MakeAddress(){
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}