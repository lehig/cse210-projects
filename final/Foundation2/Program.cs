using System;

class Program
{
    static void Main(string[] args)
    {
        Products toiletPaper = new Products("Toilet Paper", "78954", 10.25);
        Products phoneCable = new Products("Phone Cable", "85641", 2.50);
        Products monitor = new Products("Monitor", "56412", 500.20);
        Products keyboard = new Products("Keyboard", "98542", 62.02);
        Products shelves = new Products("Shelves - 3 sections", "96541", 98.20);
        Products desks = new Products("Desks - 12x4", "87496", 321.30);

        List<Products> company1ProductList = new List<Products>();
        company1ProductList.Add(phoneCable);
        company1ProductList.Add(keyboard);
        company1ProductList.Add(shelves);

        List<int> company1QuantityList = new List<int>();
        company1QuantityList.Add(50);
        company1QuantityList.Add(20);
        company1QuantityList.Add(10);

        List<Products> secondCompanyProductList = new List<Products>();
        secondCompanyProductList.Add(toiletPaper);
        secondCompanyProductList.Add(shelves);
        secondCompanyProductList.Add(desks);

        List<int> secondCompanyQuantityList = new List<int>();
        secondCompanyQuantityList.Add(95);
        secondCompanyQuantityList.Add(300);
        secondCompanyQuantityList.Add(120);

        Address company1Address = new Address("411 Columbus St.", "Houston", "TX", "USA");
        Address secondCompanyAddress = new Address("1200 Santa Lucia Calle", "Santiago de los Caballeros", "Santiago", "Dominican Republic");

        Customer company1Customer = new Customer("Druidia", company1Address);
        Customer secondCustomer = new Customer("Los Sabados", secondCompanyAddress);

        Order Company1Order = new Order(company1Customer, company1ProductList, company1QuantityList);
        Order secondCompanyOrder = new Order(secondCustomer, secondCompanyProductList, secondCompanyQuantityList);

        List<Order> orders = new List<Order>();
        orders.Add(Company1Order);
        orders.Add(secondCompanyOrder);

        foreach(Order order in orders){
            Console.WriteLine($"{order.GetName()}'s Packing Label: ");
            Console.WriteLine($"{order.PackingLabel()}");
            Console.WriteLine();
            Console.WriteLine($"{order.GetName()}'s Shipping Label: ");
            Console.WriteLine($"{order.ShippingLabel()}");
            Console.WriteLine();
        }
        

    }
}