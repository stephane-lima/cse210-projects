using System;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public int ShippingCost()
    {
        int _shippingfee = 0;
        bool _check = _customer.CheckAddressUSA();
        if (_check == true)
        {
            _shippingfee = 5;
        }
        else
            _shippingfee = 35;
        return _shippingfee;
    }

    public void AddProduct(Product product)//add items to the list before loop through it.
    {
        _products.Add(product);
    }
    public int OrderTotal()
    {
        int _itemFee = 0;
        foreach (Product product in _products)
        {
            _itemFee += product.ProductFee();
        }
        int _orderTotal = _itemFee + ShippingCost();
        return _orderTotal;
    }
    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            product.DisplayProduct();
        }
    }
    public void ShippingLabel(Customer customer)
    {
        customer.DisplayCustomer();
    }

}