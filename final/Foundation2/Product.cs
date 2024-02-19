using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;

    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _name;
    }
    public void SetProductName(string name)
    {
        _name = name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public void SetProductId(string producId)
    {
        _productId = producId;
    }

    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}