
using System;
class Product
{
    private string _name;
    private int _productId;
    private double _pricePerUnit;
    private int _quantity;


    public Product(string name, int productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public override string ToString()
    {
        return $"Product: {_name}\nID: {_productId}\nPrice per Unit: {_pricePerUnit:C}\nQuantity: {_quantity}\nTotal Cost: {GetTotalCost():C}";
    }
}