using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Address cust1Address = new Address(12, "Ihioma", "Port Harcourt", "Rivers State", "Nigeria");

        Customer cust1 = new Customer("Mr Morris", cust1Address);
        Product p1 = new Product("Hair cream", 1023, 34.5m, 16);
        p1.DisplayProductDetails();
        Order ord1 = new Order(cust1);
        // var _products = new List<Product>();
        ord1.GetProductList().Add(p1);
        System.Console.WriteLine(ord1.GetShippingCost());
        System.Console.WriteLine(ord1.GetProductList().Count);
        cust1Address.DisplayAddress();
        System.Console.WriteLine(ord1.GetPackingLabel());
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine(ord1.GetCustomer().GetAddress().DisplayAddress2());
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine(ord1.GetShippingLabel());

    }
}