public class Product
{
    private string _name;
    private string _product;
    private double _price;
    private int _quantity;
    public Product()
    {
        _name="";
        _product="";
        _price=0;
        _quantity=0;
    }
    public Product(string name, string product, double price, int quantity)
    {
        _name=name;
        _product=product;
        _price=price;
        _quantity=quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetProduct()
    {
        return _product;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetName(string name)
    {
        _name=name;
    }
    public void SetProduct(string product)
    {
        _product=product;
    }  
    public void SetPrice(double price)
    {
        _price=price;
    }  
    public void SetQuantity(int quantity)
    {
        _quantity=quantity;
    }  
    public double TotalPrice()
    {
        return _price*_quantity;
    }        
}