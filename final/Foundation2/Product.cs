using System;

class Product
{
    private string _productName;
    private string _ID;
    private int _price;
    private int _quantity;

    public Product(string name, string ID, int unitPrice, int quantity)
    {
        _productName = name;
        _ID = ID;
        _price = unitPrice;
        _quantity = quantity;
    }
    public int ProductFee()
    {
        return (_price * _quantity);
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"'{_ID}'     {_productName}");
        Console.Write($"{_quantity} @ ${_price}      ");
        Console.WriteLine($"${ProductFee()}");

    }
}