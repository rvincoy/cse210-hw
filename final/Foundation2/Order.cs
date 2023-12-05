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
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double TotalCost()
    {
        double tc=0;
        foreach (Product product in _products)
        {
            tc=tc+product.TotalPrice();
        }
        return tc;
    }
    public string PackingLabel()
    {
        string packingLabel="USPS Priority Mail\n\n\nUniversal Exporters\n14 Pine Street\nOrlando, FL 32050 USA\n\n\n" + _customer.GetAddressPackingLabel();
        return packingLabel;
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