public class Customer{
    private string _name = "";
    private Address _address;
    private bool _isInUSA = true;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    private void SetIsInUSA(){
        _isInUSA = _address.InUSA();
    }
    public string GetIsInUSA(){
        SetIsInUSA();
        if (_isInUSA){
            return "Yes";
        }
        else{
            return "No";
        }
    }
    public string GetName(){
        return _name;
    }
    public string GetAddress(){
        return _address.MakeAddress();
    }
}