public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUsa()
    {
        if (_address.LivesInUsa() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ShippingInfo()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine();
        _address.WriteFullAddress();
    }
}