
class Order
{
    List<Product> _products;
    Customer _customer;

    public Order()
    {
        _products = new List<Product>();
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetShippingCost()
    {
        if (_customer.GetAddress().IsInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public float CalculateTotalCost()
    {
        float totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }
        totalCost += GetShippingCost();
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetName()}\n";
        shippingLabel += $"{_customer.GetAddress().GetFullAddress()}\n";
        return shippingLabel;
    }
}