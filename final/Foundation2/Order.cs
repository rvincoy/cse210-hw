using System.Net.Sockets;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order()
    {
        _customer= new Customer();
    }
    public Order(Customer customer)
    {
        _customer=customer;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public void SetCustomer(Customer customer)
    {
        _customer=customer;
    }
    public void SetProducts(List<Product> products)
    {
        _products=products;
    }
    public Product GetProduct(int index)
    {
        return _products[index];
    }
    public void SetProduct(int index, Product product)
    {
        _products[index]=product;
    }
    public float TotalCost()
    {
        float tc=0;
        foreach (Product product in _products)
        {
            tc=tc+product.TotalPrice();
        }
        return tc;
    }
    public string PackingLabel()
    {
        return _customer.GetAddressPackingLabel();
    }
    public float ShippingCost()
    {
        float s;
        if (_customer.GetCountry()=="USA")
            s=5;
        else
            s=35;
        return s;
    }
    public string ShippingLabel()
    {
        return _customer.GetAddressPackingLabel();
    }
}