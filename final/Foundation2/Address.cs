using System;


public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    private bool _isUSBase;

    public Address(string street, string city, string stateOrProvince, string country, bool isUSBase)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
        _isUSBase = isUSBase;
    }

    public bool IsUSBase()
    {
        return _isUSBase;
    }

    public string GetDisplayAddress()
    {
        return $"{_street},{_city},{_stateOrProvince},{_country}";
    }
}