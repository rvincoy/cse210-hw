public class Customer
{
    private string _name;
    private Address _address;
    public Customer()
    {
        _name="";
        _address = new Address();
    }
    public Customer(string name, string streetAddress, string city, string stateProvince, string country)
    {
        _name=name;
        _address = new Address(streetAddress,city,stateProvince,country);
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetName(string name)
    {
        _name=name;
    }
    public void SetAddress(Address address)
    {
        _address=address;
    }
    public string GetCountry()
    {
        return _address.GetCountry();
    }
    public string GetAddressPackingLabel()
    {
        string label="";
        label = _name + "\n";
        label = label + _address.GetStreetAddress() + "\n";
        label = label + _address.GetCity() + ", " + _address.GetStateProvince() + "\n";
        label = label + _address.GetCountry() + "\n";
        return label;
    }
}