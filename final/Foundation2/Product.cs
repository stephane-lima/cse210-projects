using System;

class Product
{
    private string _productName;
    private string _productId;
    private int _price;
    private int _quantity;

    public Product(string name, string productId, int unitPrice, int quantity)
    {
        _productName = name;
        _productId = productId;
        _price = unitPrice;
        _quantity = quantity;
    }
    public int ProductFee()
    {
        return (_price * _quantity);
    }
    public void DisplayProduct()
    {
        // Console.WriteLine($"'{_ID}'     {_productName}");
        // Console.Write($"{_quantity} @ ${_price}      ");
        Console.WriteLine($"{_productId} - {_quantity}x {_productName} - ${_price} each - ${ProductFee()}");
        // Console.WriteLine($"${ProductFee()}");
    }
}