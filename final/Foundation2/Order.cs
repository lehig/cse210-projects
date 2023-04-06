public class Order{
    private List<Products> _shoppingList = new List<Products>();
    private Customer _customer;
    private double _shippingCost = 0.0;
    private double _totalCost = 0.0;
    private List<int> _quantity = new List<int>();
    private bool _isInUSA = true;
    public Order(Customer customer, List<Products> products, List<int> quantity){
        _quantity = quantity;
        _customer = customer;
        _shoppingList = products;
    }
    private void ShippingCost(){
        if (_isInUSA){
            _shippingCost = 5.00;
        }
        else{
            _shippingCost = 35.00;
        }
    }

    private void TotalCost(){
        int i = 0;
        ShippingCost();
        foreach(Products product in _shoppingList){
            double productPrice = product.GetPrice(_quantity[i]);
            _totalCost += productPrice;
            i += 1;
        }
        _totalCost += _shippingCost;       
    }
    public string ShippingLabel(){
        return $"Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
    }
    public string PackingLabel(){
        TotalCost();
        string packingLabel =  $"Customer Name: {_customer.GetName()}\n";
        packingLabel += $"USA: {_customer.GetIsInUSA()}\n";
        foreach(Products product in _shoppingList){
            packingLabel += $"Product: {product.GetName()} ({product.GetProductID()})\n";
        }
        packingLabel += $"Total: ${_totalCost:n}";
        
        return packingLabel;
    }

    public string GetName(){
        return _customer.GetName();
    }
}