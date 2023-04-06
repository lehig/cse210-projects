public class Products{
    private string _name = "";
    private string _productID = "";
    private double _price = 0.0;

    public Products(string name, string productID, double price){
        _name = name; 
        _productID = productID;
        _price = price;
    }

    public double GetPrice(int quantity){
        return _price * quantity;
    }
    public string GetProductID(){
        return _productID;
    }
    public string GetName(){
        return _name;
    }
}