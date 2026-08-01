class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {
        
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
{
    return _address.IsInUSA();
}
}