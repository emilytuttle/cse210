public class Product
{
    public string _name;
    public int _productId;
    private int _price;
    public int _quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

   

    public int CalculateTotalProductCost()
    {
        // Console.Write(_price*_quantity);
        return _price*_quantity;
    }
    public int ReturnTotalProductCost()
    {
        return _price*_quantity;
    }
}