using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Product
{
    private string _name;
    private int _id;
    private decimal _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _pricePerUnit = price;
        _quantity = quantity;        
    }

    //________Name_____________
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

        //________ID_____________
    public int GetId()
    {
        return _id;
    }
    public void SetId(int id)
    {
         _id = id;
    }

        //________Price_____________
    public decimal GetPrice()
    {
        return _pricePerUnit;
    }
    public void SetPrice(decimal price)
    {
        _pricePerUnit = price;
    }

        //________Quantity_____________
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

        //________Methods_____________
    public decimal ProductTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }

    public void DisplayProductDetails()
    {
        System.Console.WriteLine($"The {_name} with an id of {_id} costs {_pricePerUnit} each.");
    }
    
}