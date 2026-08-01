using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address usaAddress = new Address();
        usaAddress.SetStreetAddress("123 Apple Street");
        usaAddress.SetCity("Salt Lake City");
        usaAddress.SetStateProvince("UT");
        usaAddress.SetCountry("USA");

        Customer usaCustomer = new Customer();
        usaCustomer.SetName("John Doe");
        usaCustomer.SetAddress(usaAddress);
        Order order1 = new Order();
        order1.SetCustomer(usaCustomer);

        Product product1 = new Product();

        product1.SetName("Wireless Mouse");
        product1.SetProductId("WM-001");
        product1.SetPrice(25.99);
        product1.SetQuantity(2);

        order1.AddProduct(product1);

        Product product2 = new Product();
        product2.SetName("USB-C Cable");
        product2.SetProductId("USB-042");
        product2.SetPrice(12.50);
        product2.SetQuantity(3);
        order1.AddProduct(product2);

        Product product3 = new Product();
        product3.SetName("Mechanical Keyboard");
        product3.SetProductId("KB-007");
        product3.SetPrice(89.99);
        product3.SetQuantity(1);
        order1.AddProduct(product3);


        Address intlAddress = new Address();
        intlAddress.SetStreetAddress("45 Mosunmola Street");
        intlAddress.SetCity("Egbeda");
        intlAddress.SetStateProvince("Lagos");
        intlAddress.SetCountry("Nigeria");

        Customer intlCustomer = new Customer();
        intlCustomer.SetName("Marie Curie");
        intlCustomer.SetAddress(intlAddress);
        Order order2 = new Order();
        order2.SetCustomer(intlCustomer);

        Product product4 = new Product();
        product4.SetName("Bluetooth Speaker");
        product4.SetProductId("SPK-101");
        product4.SetPrice(49.99);
        product4.SetQuantity(1);
        order2.AddProduct(product4);

        Product product5 = new Product();
        product5.SetName("Laptop Stand");
        product5.SetProductId("STND-22");
        product5.SetPrice(34.95);
        product5.SetQuantity(2);
        order2.AddProduct(product5);


        Console.WriteLine("\n" + order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Price: ${order1.CalculateTotalCost():F2}\n");


        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Price: ${order2.CalculateTotalCost():F2}\n");

    }
}