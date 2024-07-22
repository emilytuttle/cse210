using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("orange", 1111, 2, 7);
        Product product2 = new Product("apple", 2222, 3, 1);
        Product product3 = new Product("banana", 3333, 1, 4);
        Product product4 = new Product("kiwi", 4444, 7, 1);
        Product product5 = new Product("grapes", 5555, 9, 1);
        Product product6 = new Product("milk", 6543, 2, 3);
        Product product7 = new Product("juice", 8172, 10, 1);

        Address address1 = new Address("1234 E Pine Wy", "Sunnyville", "CO", "USA");
        Address address2 = new Address("5543 S Oak Dr", "Snowflake", "AZ", "USA");
        Address address3 = new Address("9984 W Pine Dr", "Milan", "MP", "ITA");

        Customer customer1 = new Customer("Joe", address1);
        Customer customer2 = new Customer("Sal", address2);
        Customer customer3 = new Customer("Mike", address3);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        order1.AddProductToOrder(product1);
        order1.AddProductToOrder(product2);
        order1.AddProductToOrder(product3);

        order2.AddProductToOrder(product4);
        order2.AddProductToOrder(product5);

        order3.AddProductToOrder(product6);
        order3.AddProductToOrder(product7);

        order1.CreatePackingLabel();
        order1.CreateShippingLabel();

        order2.CreatePackingLabel();
        order2.CreateShippingLabel();

        order3.CreatePackingLabel();
        order3.CreateShippingLabel();
        

    }
}