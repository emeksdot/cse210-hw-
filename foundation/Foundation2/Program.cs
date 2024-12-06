using System;

class Program
{
    static void Main(string[] args)
    {
        Address cust1Address = new Address(12, "Ihioma", "Port Harcourt", "Rivers State", "Nigeria");
        Address cust2Address = new Address(1234, "St Mary", "Boise", "Idaho State", "USA");

        Customer cust1 = new Customer("Mr Morris", cust1Address);
        Customer cust2 = new Customer("Jane Smith", cust2Address);

        Product p1Cust1 = new Product("Leather Belt", 1273, 34.5m, 2);
        Product p2Cust1 = new Product("Wrist Watch", 2391, 163.75m, 1);
        Product p3Cust1 = new Product("Brief Case", 5533, 45.69m, 1);

        Product p1Cust2 = new Product("Hair cream", 1023, 34.5m, 1);
        Product p2Cust2 = new Product("Armani Hand Bag", 1075, 3420.5m, 2);
        Product p3Cust2 = new Product("Lip Gloss", 6083, 14.56m, 3);

        // p1.DisplayProductDetails();

        Order ord1 = new Order(cust1);        
        Order ord2 = new Order(cust2);

        ord1.GetProductList().Add(p1Cust1);
        ord1.GetProductList().Add(p2Cust1);
        ord1.GetProductList().Add(p3Cust1);

        ord2.GetProductList().Add(p1Cust2);
        ord2.GetProductList().Add(p2Cust2);
        ord2.GetProductList().Add(p3Cust2);



        // var _products = new List<Product>();
        // ord1.GetProductList().Add(p1);
        // System.Console.WriteLine(ord1.GetShippingCost());
        // System.Console.WriteLine(ord2.GetShippingCost());
        // System.Console.WriteLine(ord1.GetProductList().Count);
        // System.Console.WriteLine(ord2.GetProductList().Count);

        System.Console.WriteLine($"Total quantity of products for cust1 is: {ord1.GetTotalQuantity()}");
        System.Console.WriteLine($"Total quantity of products for cust2 is: {ord2.GetTotalQuantity()}");

        System.Console.WriteLine();
        System.Console.WriteLine($"The total product cost for cust1 is: ${ord1.TotalProductsCost()}");
        System.Console.WriteLine($"The total product cost for cust2 is: ${ord2.TotalProductsCost()}");
        // System.Console.WriteLine(ord2.TotalProductsCost());

        // cust1Address.DisplayAddress();
        System.Console.WriteLine();
        // cust2Address.DisplayAddress();
        System.Console.WriteLine();

        // System.Console.WriteLine($"{}");
        System.Console.WriteLine($"PACKING LABEL: CUST1");
        System.Console.WriteLine(ord1.GetPackingLabel());
        System.Console.WriteLine();
        System.Console.WriteLine($"PACKING LABEL: CUST2");
        System.Console.WriteLine(ord2.GetPackingLabel());
        System.Console.WriteLine();
        // System.Console.WriteLine(ord2.GetPackingLabel());
        System.Console.WriteLine();
        System.Console.WriteLine(ord1.GetCustomer().GetAddress().DisplayAddress2());
        System.Console.WriteLine();
        System.Console.WriteLine(ord2.GetCustomer().GetAddress().DisplayAddress2());
        System.Console.WriteLine();
        System.Console.WriteLine(ord1.GetShippingLabel());
        System.Console.WriteLine();
        System.Console.WriteLine(ord2.GetShippingLabel());
        System.Console.WriteLine();

    }
}