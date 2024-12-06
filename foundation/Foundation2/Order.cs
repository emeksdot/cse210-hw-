using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();        
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public List<Product> GetProductList()
    {
        return _products;
    }

    public decimal GetShippingCost()
    {
        if (_customer.GetAddress().GetCountry() == "USA")
        {
            return 5m;
        }
        else
        {
            return 35m;
        }
    }

    public void DisplayTotalPrice()
    {

    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
           packingLabel += product.GetName() + " " + product.GetId();
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        // .GetAddress().DisplayAddress2()
        string shippingLabel =  $"{_customer.GetCustomerName()}\n{_customer.GetAddress().DisplayAddress2()}";
        return shippingLabel;
    }
    
}