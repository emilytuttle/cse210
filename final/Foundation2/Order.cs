public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;
    private int _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProductToOrder(Product product)
    {
        _productList.Add(product);
    }

    public void ShippingCost()
    {
        if (_customer.LivesInUsa() == true)
        {
            _shippingCost = 5;
        }
        else{
            _shippingCost = 35;
        }
    }

    public void CreateShippingLabel()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine();
        _customer.ShippingInfo();
        Console.WriteLine("--------------------------------------------------");
        
    }

    public void CreatePackingLabel()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine();
        int totalCost = 0; 
        foreach (Product product in _productList)
        {
            Console.WriteLine($"Item#: {product._productId}  Product: {product._name}, Quantity: {product._quantity}, Price: ${product.CalculateTotalProductCost()}" );
            totalCost += product.ReturnTotalProductCost();
        }
        ShippingCost();
        int finalCost = totalCost + _shippingCost;
        Console.WriteLine();
        Console.WriteLine($"Items total: ${totalCost}");
        Console.WriteLine($"Shipping: ${_shippingCost}");
        Console.WriteLine($"Total Cost: ${finalCost}");
        

    }
}