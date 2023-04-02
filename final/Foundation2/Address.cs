using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
            return false;
    }
    // public void DisplayAddress()//it's only function is to display to Console.
    // {
    //     Console.WriteLine($"{_street}");
    //     Console.WriteLine($"{_city}");
    //     Console.WriteLine($"{_state}");
    //     Console.WriteLine($"{_country}.");
    // }
    public string CustomerAddress()//it has more use in many different ways.
    {
        string address = "";
        address += $"{_street}\n";
        address += $"{_city}\n";
        address += $"{_state}\n";
        address += $"{_country}\n";
        return address;
    }
    //The address should have a method to return a string all of its fields together in one string.

}