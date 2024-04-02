using System;
using System.Text;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Adding shipping cost based on customer location
        if (customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }



    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += product.ToString() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += customer.ToString() + "\n";
        shippingLabel += $"Total Cost: {CalculateTotalCost():C}";
        return shippingLabel;
    }
}
