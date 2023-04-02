using System;

class Customer
{
    private string _customerName;
    public Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }
    public bool CheckAddressUSA()
    {
        // bool _inUSA = _address.InUSA(); this is another way to return the function 
        // return _inUSA; (create a variable and return it) 
        //or just return the function as below:
        return _address.InUSA();
    }
    public void DisplayCustomer()
    {
        Console.WriteLine();
        Console.WriteLine($"{_customerName}");
        //_address.DisplayAddress();
        Console.WriteLine(_address.CustomerAddress());
    }
}