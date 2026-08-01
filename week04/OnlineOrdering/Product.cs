class Product
{
    
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product()
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
    public void SetProductId(string productId)
    {
        _productId = productId;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    public float TotalCost()
    {
        return _quantity * (float)_price;
    }
}