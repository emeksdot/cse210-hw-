using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Address
{
    private int _streetNumber;
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(int streetNumber, string street, string city, string state, string country)
    {
        _streetNumber = streetNumber;
        _street =  street;
        _city = city;
        _state = state;
        _country = country;        
    }

    public int GetStreetNumber()
    {
        return _streetNumber;
    }
    public void SetStreetNumber(int streetNumber)
    {
        _streetNumber = streetNumber;
    }
    public string GetStreet()
    {
        return _street;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetState()
    {
        return _state;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry( string country)
    {
         _country = country;
    }

    public bool IsUSABased()
    {
        if (_country == "USA" || _country == "United States of America" || _country == "US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayAddress()
    {
        System.Console.WriteLine($"{_streetNumber} {_street} Street \n{_city} \n{_state} \n{_country}");
    }


    
}