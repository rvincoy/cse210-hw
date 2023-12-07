public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address()
    {
        _streetAddress="";
        _city="";
        _stateProvince="";
        _country="";
    }
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress=streetAddress;
        _city=city;
        _stateProvince=stateProvince;
        _country=country;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetStateProvince()
    {
        return _stateProvince;
    }
    public string GetCountry()
    {
        return _country;
    }
    public string GetAddressFormatted()
    {
        string a;
        a = _streetAddress + "\n";
        a = a + _city + ", " + _stateProvince + " " + _country;
        return a;
    } 
}