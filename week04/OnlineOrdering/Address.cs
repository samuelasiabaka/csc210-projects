class Address
{
    private string _streetAddress;
    private string _city;

    private string _stateProvince;
    private string _country;

    public Address()
    {
        
    }

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetCity()
    {
        return _city;
    }public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }
    public string GetStateProvince()
    {
        return _stateProvince;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetCountry()
    {
        return _country;
    }

    public bool IsInUSA()
    {
        return _country.Trim().Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}