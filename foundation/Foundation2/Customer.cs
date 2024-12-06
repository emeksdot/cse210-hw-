using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Customer
{ 
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;  
        _address = address;
    }

    //________Name_____________
    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

        //________Address_____________
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsUSABased();
    }
    
}


